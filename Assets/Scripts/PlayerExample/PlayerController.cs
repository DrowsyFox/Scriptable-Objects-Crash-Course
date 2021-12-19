// Copyright 2021 DrowsyFox LLC

using Sirenix.OdinInspector;
using UnityEngine;

namespace DrowsyFox.PlayerExample
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        [InlineEditor(InlineEditorObjectFieldModes.Boxed, Expanded = true)]
        [OnValueChanged("RefreshEquipment", true)]
        private PlayerConfigSO config;


        private void Start()
        {
            parentRotationAnchor = transform.parent;
            RefreshEquipment();
        }

        private void FixedUpdate()
        {
            parentRotationAnchor.Rotate(Vector3.forward,
                config.runtimeSpeed * Time.fixedDeltaTime);
        }

        public void RefreshEquipment()
        {
            vehicleGfx.sprite = config.vehicleSprite;
            characterGfx.sprite = config.characterSprite;
            trailGfx.colorGradient = config.trailColor;
        }


        #region component refs

        [SerializeField] [FoldoutGroup("references")]
        private SpriteRenderer vehicleGfx, characterGfx;

        [SerializeField] [FoldoutGroup("references")]
        private TrailRenderer trailGfx;

        private Transform parentRotationAnchor;

        #endregion
    }
}