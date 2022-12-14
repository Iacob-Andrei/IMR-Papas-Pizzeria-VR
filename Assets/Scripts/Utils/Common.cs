using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class Common
    {
        public static void PrintUsedMap(Dictionary<string, int> dict)
        {
            var text = " ";
            foreach (var (key, value) in dict)
            {
                text += $"{key}: {value}, ";
            }
            Debug.Log(text);
        }
        
        public static IEnumerator WaitFor2Seconds()
        {
            yield return new WaitForSeconds(5);
        }
    }
}