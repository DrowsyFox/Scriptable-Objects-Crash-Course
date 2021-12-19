// Copyright 2021 DrowsyFox LLC

using Sirenix.OdinInspector;
using UnityEngine;

namespace DrowsyFox.LifeCycleExample
{
    public class LifeCycleHolder : MonoBehaviour
    {
        public LifeCycleSO lifeCycleAsset;


        [Title("In Memory Life Cycle SO")] [InlineEditor(InlineEditorObjectFieldModes.Boxed)]
        public LifeCycleSO inMemoryLifeCycle;

        [Button]
        public void CreateLifeCycleInMemory()
        {
            inMemoryLifeCycle = ScriptableObject.CreateInstance<LifeCycleSO>();
        }


        [Button]
        public void DestroyLifeCycle()
        {
            DestroyImmediate(inMemoryLifeCycle, true);
        }
    }
}