using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeGenerator : MonoBehaviour
{
        bool ok = true;
        int curentDifference = 0;

    [SerializeField] Text recipeText; 

    void Start()
    {
        recipeText.text = "There are no recipes yet";
    }

    void Update()
    {  
        
        if (CountDownTimer.startingTime-CountDownTimer.currentTime>3)
            {
                int normalizedValue = (int)(CountDownTimer.startingTime-CountDownTimer.currentTime);
                if(normalizedValue != curentDifference)
                {
                    ok = true;
                    curentDifference = normalizedValue;
                }

                if (normalizedValue%5 == 0 && ok == true)
                {
                    recipeText.text = recipGenerator();
                    ok = false;
                }
            }
               
    }

    public string recipGenerator(){
        string[] ingredients = new string[]{"salami","tomato","mushroom","mozzarella","pepper","olive"};
        string recipeResult = "";
        float randomNumber;
        foreach (string ing in ingredients){
            randomNumber = Random.Range(0, 3);
            if(randomNumber>0)
               recipeResult+=randomNumber + "x" + ing + "\n";
        }

        return recipeResult;
            

    }
}
