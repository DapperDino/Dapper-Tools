using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DapperDino.DapperTools.SavingLoading
{
    [ExecuteAlways]
    public class SaveableEntity : MonoBehaviour
    {
        [SerializeField] private string id = string.Empty;

        private static Dictionary<string, SaveableEntity> globalLookup = new Dictionary<string, SaveableEntity>();

        public string Id => id;

        public object CaptureState()
        {
            // Create a dictionary to store save data for this GameObject
            var state = new Dictionary<string, object>();

            // Store all the save data from the saveable components on this GameObject
            foreach (var saveable in GetComponents<ISaveable>())
            {
                state[saveable.GetType().ToString()] = saveable.CaptureState();
            }

            // Return the save data to be saved to disk
            return state;
        }

        public void RestoreState(object state)
        {
            var stateDictionary = (Dictionary<string, object>)state;

            foreach (var saveable in GetComponents<ISaveable>())
            {
                var typeName = saveable.GetType().ToString();

                if (stateDictionary.TryGetValue(typeName, out object value))
                {
                    saveable.RestoreState(value);
                }
            }
        }

#if UNITY_EDITOR

        private void Update()
        {
            if (Application.IsPlaying(gameObject)) { return; }
            if (string.IsNullOrEmpty(gameObject.scene.path)) { return; }

            var serializedObject = new SerializedObject(this);
            var property = serializedObject.FindProperty("id");

            if (string.IsNullOrEmpty(property.stringValue) || !IsUnique(property.stringValue))
            {
                property.stringValue = Guid.NewGuid().ToString();
                serializedObject.ApplyModifiedProperties();
            }

            globalLookup[property.stringValue] = this;
        }

#endif

        private bool IsUnique(string candidate)
        {
            if (!globalLookup.ContainsKey(candidate)) { return true; }

            if (globalLookup[candidate] == this) { return true; }

            if(globalLookup[candidate] == null)
            {
                globalLookup.Remove(candidate);
                return true;
            }

            if(globalLookup[candidate].Id != candidate)
            {
                globalLookup.Remove(candidate);
                return true;
            }

            return false;
        }
    }
}
