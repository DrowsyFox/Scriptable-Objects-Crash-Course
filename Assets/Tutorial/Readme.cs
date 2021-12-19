// Copyright 2021 DrowsyFox LLC

using System;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace DrowsyFox.DrowsyFox
{
    [CreateAssetMenu()]
    public class Readme : ScriptableObject
    {
        public bool Edit;
        public Texture2D icon;
        public string title;
        public Section[] sections;
        public Requirement[] requirements;
        public bool loadedLayout;

        [Serializable]
        public class Section
        {
            [TextArea]
            public string text;
            
            public string heading, linkText, url;
        }

        [Serializable]
        public class Requirement
        {
            public string name, linkText, url;

            [SerializeField] private string reqNamespace, Symbol;

            public bool pass;

            public void Test()
            {
                if (!string.IsNullOrEmpty(reqNamespace))
                {
                    pass = NamespaceExists(reqNamespace);
                }
                else if (!string.IsNullOrEmpty(Symbol))
                {
                    pass = EnsureScriptingDefineSymbol();
                }
                else
                {
                    pass = false;
                    Debug.LogError("Missing namespace or symbol name for requirement!");
                }
            }

            private bool EnsureScriptingDefineSymbol()
            {
                var currentTarget = EditorUserBuildSettings.selectedBuildTargetGroup;

                if (currentTarget == BuildTargetGroup.Unknown)
                {
                    return false;
                }

                var definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(currentTarget).Trim();
                var defines = definesString.Split(';');


                return defines.Contains(Symbol);
            }

            private bool NamespaceExists(string ns)
            {
                foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (assembly.GetTypes().Any(type => type.Namespace ==ns ))
                        return true;
                }

                return false;
            }
        }

        private void OnValidate()
        {
            OnEnable();
        }

        private void OnEnable()
        {
            foreach (var requirement in requirements)
            { 
                requirement.Test();
            }
        }
    }
}