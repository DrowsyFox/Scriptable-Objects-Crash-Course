// Copyright 2021 DrowsyFox LLC

using Sirenix.OdinInspector;
using UnityEngine;

namespace DrowsyFox.CharacterConfig
{
    public class CharacterComponentModular : MonoBehaviour
    {
        [InlineEditor(InlineEditorObjectFieldModes.Boxed)]
        public CharacterConfigSO CharacterModule;
    }
}