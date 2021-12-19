// Copyright 2021 DrowsyFox LLC

using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace DrowsyFox.PlayerExample
{
    [CreateAssetMenu(menuName = "Create PlayerConfigSO",
        fileName = "PlayerConfigSO", order = 0)]
    public class PlayerConfigSO : ScriptableObject,
        ISerializationCallbackReceiver
    {
        [SerializeField] [LabelWidth(100)] [BoxGroup("stats")] [HorizontalGroup("stats/speed")]
        private float initialSpeed;


        [PreviewField(100, ObjectFieldAlignment.Center)]
        [LabelWidth(100)]
        [BoxGroup("graphics")]
        [HorizontalGroup("graphics/sprites")]
        public Sprite vehicleSprite, characterSprite;

        [Space(15)] [BoxGroup("graphics")] public Gradient trailColor;

        [NonSerialized] [ShowInInspector] [LabelWidth(100)] [HorizontalGroup("stats/speed")]
        public float runtimeSpeed;

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            runtimeSpeed = initialSpeed;
        }
    }
}