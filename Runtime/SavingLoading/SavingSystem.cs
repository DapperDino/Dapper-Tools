using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DapperDino.DapperTools.SavingLoading
{
    public class SavingSystem : MonoBehaviour
    {
        [SerializeField] private string saveFileName = "SaveData";

        private string SavePath => $"{Application.persistentDataPath}{saveFileName}.sav";

        public void Save()
        {
            var state = LoadFile();
            CaptureState(state);
            SaveFile(state);
        }

        public void Load()
        {
            RestoreState(LoadFile());
        }

        private Dictionary<string, object> LoadFile()
        {
            if (!File.Exists(SavePath))
            {
                return new Dictionary<string, object>();
            }

            using (FileStream stream = File.Open(SavePath, FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                return (Dictionary<string, object>)formatter.Deserialize(stream);
            }
        }

        private void SaveFile(object state)
        {
            using (var stream = File.Open(SavePath, FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, state);
            }
        }

        private void CaptureState(Dictionary<string, object> state)
        {
            foreach (var saveable in GetComponents<SaveableEntity>())
            {
                state[saveable.Id] = saveable.CaptureState();
            }

            state["lastSceneBuildIndex"] = SceneManager.GetActiveScene().buildIndex;
        }

        private void RestoreState(Dictionary<string, object> state)
        {
            foreach (var saveable in FindObjectsOfType<SaveableEntity>())
            {
                if (state.TryGetValue(saveable.Id, out object value))
                {
                    saveable.RestoreState(value);
                }
            }
        }
    }
}
