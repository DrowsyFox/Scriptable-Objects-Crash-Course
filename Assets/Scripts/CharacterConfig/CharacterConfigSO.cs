// Copyright 2021 DrowsyFox LLC

using UnityEngine;

namespace DrowsyFox.CharacterConfig
{
    [CreateAssetMenu(menuName = "Create CharacterConfigSO", fileName = "CharacterConfigSO", order = 0)]
    public class CharacterConfigSO : ScriptableObject
    {
        public float speed;
        public float jumpHeight;
        public Sprite characterSprite;
    }
}