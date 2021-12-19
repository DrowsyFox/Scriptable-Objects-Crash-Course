// Copyright 2021 DrowsyFox LLC

using DrowsyFox.Utils;
using UnityEngine;

namespace DrowsyFox.LifeCycleExample
{
    [CreateAssetMenu(
        menuName = "Create LifeCycleSO",
        fileName = "LifeCycleSO",
        order = 0)]
    public class LifeCycleSO : ScriptableObject
    {
        public int testVar;

        private void Awake()
        {
            this.Log("Awake".Color("lightblue"),
                "triggered when the game is launched and is similar " +
                "to MonoBehavior.Awake");
        }

        private void OnEnable()
        {
            this.Log(
                "OnEnable".Color("lightblue"),
                "triggered when the object is loaded, created, " +
                "and when finished reloading script assemblies. ",
                "\n                     (Cannot be a Coroutine)".Color("yellow"));
        }

        private void OnDisable()
        {
            this.Log(
                "OnDisable".Color("lightblue"),
                "triggered when the object goes out of scope, " +
                "about to destroy, or about to reload script assemblies" +
                "\n                     (Cannot be a Coroutine)".Color("yellow"));
        }

        private void OnDestroy()
        {
            this.Log("OnDestroy".Color("lightblue"),
                "triggered when the object is destroyed.",
                "\n                     (Cannot be a Coroutine)".Color("yellow"));
        }

        private void OnValidate()
        {
            this.Log("OnValidate".Color("lightblue"),
                "Editor only event, triggered when script is loaded " +
                "or when a value changes.");
        }
    }
}