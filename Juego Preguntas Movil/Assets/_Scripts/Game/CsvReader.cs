using System;
using UnityEngine;

namespace _Scripts.Game
{
    public class CsvReader : MonoBehaviour
    {
        public static string[] Read(string file)
        {
            TextAsset textAsset = Resources.Load(file) as TextAsset;
            
            string[] data = textAsset.text.Split(new string[] { ";", "\n" }, StringSplitOptions.None);

            return data;
        }
    }
}
