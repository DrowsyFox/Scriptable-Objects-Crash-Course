// Copyright 2021 DrowsyFox LLC

#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace DrowsyFox.DFPrecompileAssembly.Odin.Editor
{
    [InitializeOnLoad]
    class AddOdinInspectorDefineIfOdinExist : AssetPostprocessor
    {
        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets,
            string[] movedAssets,
            string[] movedFromAssetPaths)
        {
            if (deletedAssets.Length > 0 && deletedAssets.Any(asset => asset.Contains("Sirenix.OdinInspector.Editor")))
            {
                ForceRemoveOdinDefine();
            }
        }

        static bool ShouldAddDefines => (AppDomain.CurrentDomain.GetAssemblies()
            .Any(x => x.FullName.StartsWith("Sirenix.OdinInspector.Editor")));

        private static readonly string ProcessingFlag = "DF_PROCESSING";
        private static readonly string[] OdinDefines = new string[] {"ODIN_INSPECTOR", "ODIN_INSPECTOR_3"};

        static AddOdinInspectorDefineIfOdinExist()
        {
            AssetDatabase.importPackageStarted += (_) => SetProcessingFlag(true);
            AssemblyReloadEvents.beforeAssemblyReload += () => AddOrRemoveOdinDefine("beforeAssemblyReload");
            AssemblyReloadEvents.afterAssemblyReload += () => AddOrRemoveOdinDefine("afterAssemblyReload");

            AddOrRemoveOdinDefine("load");
        }


        static List<string> GetPlayerDefineSymbols(BuildTargetGroup currentTarget)
        {
            if (currentTarget == BuildTargetGroup.Unknown)
            {
                return null;
            }

            var definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(currentTarget).Trim();
            return definesString.Split(';').ToList();
        }

        public static void CommitPlayerDefineSymbols(List<string> _list, BuildTargetGroup currentTarget, bool changed)
        {
            if (!changed)
            {
                return;
            }

            var distinctList = _list.Distinct();

            var definesString = string.Join(";", distinctList);
            if (definesString.EndsWith(";", StringComparison.InvariantCulture) == false)
            {
                definesString += ";";
            }

            PlayerSettings.SetScriptingDefineSymbolsForGroup(currentTarget, definesString);
        }

        static bool AddDefines(List<string> defines, params string[] args)
        {
            var toAdd = OdinDefines.Where(d => !args.Contains(d));
            defines.AddRange(toAdd);

            return toAdd.Any();
        }

        static bool RemoveDefines(List<string> defines, params string[] args)
        {
            return defines.RemoveAll(args.Contains) > 0;
        }

        public static void SetProcessingFlag(bool isProcessing)
        {
            var changed = false;
            var currentTarget = EditorUserBuildSettings.selectedBuildTargetGroup;
            var _list = GetPlayerDefineSymbols(currentTarget);
            if (_list == null)
            {
                return;
            }

            if (isProcessing)
            {
                changed = AddDefines(_list, ProcessingFlag) || changed;
            }
            else
            {
                changed = RemoveDefines(_list, ProcessingFlag) || changed;
            }

            CommitPlayerDefineSymbols(_list, currentTarget, changed);
        }

        static void ForceRemoveOdinDefine()
        {
            var changed = false;

            var currentTarget = EditorUserBuildSettings.selectedBuildTargetGroup;
            var defines = GetPlayerDefineSymbols(currentTarget);

            changed = RemoveDefines(defines, OdinDefines) || changed;
            changed = RemoveDefines(defines, ProcessingFlag) || changed;

            CommitPlayerDefineSymbols(defines, currentTarget, changed);
        }

        static void AddOrRemoveOdinDefine(string source, AssemblyLoadEventArgs args = null)
        {
            var changed = false;

            var currentTarget = EditorUserBuildSettings.selectedBuildTargetGroup;
            var defines = GetPlayerDefineSymbols(currentTarget);


            var addDefine = ShouldAddDefines;

            var hasDefine = OdinDefines.All(a => defines.Contains(a));

            if (addDefine == hasDefine)
            {
                SetProcessingFlag(false);
                return;
            }

            if (addDefine)
            {
                changed = AddDefines(defines, OdinDefines) || changed;
            }
            else
            {
                changed = RemoveDefines(defines, OdinDefines) || changed;
            }

            changed = RemoveDefines(defines, ProcessingFlag) || changed;


            CommitPlayerDefineSymbols(defines, currentTarget, changed);
        }
    }
}
#endif // UNITY_EDITOR