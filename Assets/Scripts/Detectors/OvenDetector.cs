using UnityEngine;

namespace Detectors
{
    public class OvenDetector : MonoBehaviour
    {
        private bool _hasEntered = false;
        
        public GameObject pizza;
        
        public static double time = 0;

        private void OnTriggerEnter(Collider other)
        {
            if (!_hasEntered)
            {
                if (!other.name.Contains("pizza")) return;
                
                Debug.Log("Pizza in oven");
                _hasEntered = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.name.Contains("pizza"))
            {
                _hasEntered = false;
                Debug.Log("Pizza left oven");
                Debug.Log(time);
            }
        }

        void Update()
        {
            if(_hasEntered)
            {
                time += 0.02;
                // if time > limit: -> change color of blat
            }
        }
    }
}
