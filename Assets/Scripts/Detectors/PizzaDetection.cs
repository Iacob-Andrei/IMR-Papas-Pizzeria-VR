using System.Collections;
using System.Collections.Generic;
using Menu;
using UnityEngine;
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
                    StartCoroutine(Wait2SecondsAndChangeScene());
                }
                else {
                    GameObject canvas = GameObject.FindGameObjectWithTag("GameCanvas");
                    if (canvas != null)
                    {
                        canvas.GetComponent<RecipeGenerator>().recipeText.text =
                            canvas.GetComponent<RecipeGenerator>().GeneratePizza();
                    }
                }
            }
        }

        public IEnumerator Wait2SecondsAndChangeScene()
        {
            yield return new WaitForSeconds(2f);
            SceneChanger.GetToFinalScene();
        }
    }
}
