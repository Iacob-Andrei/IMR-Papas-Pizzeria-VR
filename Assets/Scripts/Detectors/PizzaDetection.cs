using System.Collections;
using System.Collections.Generic;
using EndGame;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.XR.Interaction.Toolkit;
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
                XRGrabInteractable xr = other.gameObject.GetComponent<XRGrabInteractable>();
                Destroy(xr);

                ScoreGenerator.AddToScore(other.gameObject.GetComponent<IngredientPlacement>().used, RecipeGenerator.recipe,OvenDetector.time);
                
                if (RecipeGenerator.numberOfPizza == 0)
                {
                    WaitSecondsBeforeSceneChange();
                    EndGameSceneChanger.GetToFinalSceneWhenThereIsNoPizza();
                }
                // generate new recipe
            }
        }

        private void WaitSecondsBeforeSceneChange()
        {
            StartCoroutine(Common.WaitFor2Seconds());
        }
    }
}
