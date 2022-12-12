using System.Collections;
using EndGame;
using UnityEngine;
using Utils;

namespace Detectors
{
    public class PizzaDetection : MonoBehaviour
    {
        private bool _hasEntered = false;

        public GameObject pizza;
        
        private void OnTriggerEnter(Collider other)
        {
            if (_hasEntered) return;
            
            if (other.name.Contains("pizza"))
            {
                _hasEntered = true;
                RecipeGenerator.UpdateNumberOfPizza(RecipeGenerator.numberOfPizza - 1);
                
                if (RecipeGenerator.numberOfPizza == 0)
                {
                    WaitSecondsBeforeSceneChange();
                    EndGameSceneChanger.GetToFinalSceneWhenThereIsNoPizza();
                }
                
                //Debug.Log($"Pizza trigger entered. {numberOfPizza} pizza remaining.");

                // generate new recipe
            }
        }

        private void WaitSecondsBeforeSceneChange()
        {
            StartCoroutine(Common.WaitFor2Seconds());
        }
    }
}
