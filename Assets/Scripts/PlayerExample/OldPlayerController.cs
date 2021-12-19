// Copyright 2021 DrowsyFox LLC

using Sirenix.OdinInspector;
using UnityEngine;

namespace DrowsyFox.PlayerExample
{
    public class OldPlayerController : MonoBehaviour
    {
        [SerializeField] [BoxGroup("stats")] [OnValueChanged("RefreshEquipment")]
        private float speed = 1;

        [SerializeField] [BoxGroup("stats")] [OnValueChanged("RefreshEquipment")]
        private Sprite vehicleSprite, characterSprite;

        [SerializeField] [BoxGroup("stats")] [OnValueChanged("RefreshEquipment")]
        private Gradient trailColor;

        [SerializeField] [FoldoutGroup("references")]
        private SpriteRenderer vehicleGfx, characterGfx;

        [SerializeField] [FoldoutGroup("references")]
        private TrailRenderer trailGfx;

        private Transform parentRotationAnchor;

        private void Start()
        {
            parentRotationAnchor = transform.parent;
            RefreshEquipment();
        }

        private void FixedUpdate()
        {
            parentRotationAnchor.Rotate(Vector3.forward, speed * Time.fixedDeltaTime);
        }

        public void RefreshEquipment()
        {
            vehicleGfx.sprite = vehicleSprite;
            characterGfx.sprite = characterSprite;
            trailGfx.colorGradient = trailColor;
        }
    }
}