using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeGenerator : MonoBehaviour
{
    bool ok = true;
    int currentDifference = 0, currentTable=-1;
    private Dictionary<string, int> recipe = new Dictionary<string, int>();
    private List<string> ingredients = new List<string>
        { "salami", "olive", "tomato", "mushroom", "mozzarella", "pepper" };
    private string table;
    [SerializeField] Text recipeText; 
     

    public List<GameObject> tables = new List<GameObject>();


    void Start()
    {
        recipeText.text = "There are no recipes yet";
    }

    void Update()
    {
        if (CountDownTimer.startingTime-CountDownTimer.currentTime>3)
            {
                int normalizedValue = (int)(CountDownTimer.startingTime-CountDownTimer.currentTime);
                if(normalizedValue != currentDifference)
                {
                    ok = true;
                    currentDifference = normalizedValue;
                }

                if (normalizedValue%5 == 0 && ok == true)
                {
                    recipeText.text = recipGenerator();
                    ok = false;
                }
            }
    }

    public string recipGenerator()
    {
        string recipeResult = "Recipe:\n";
        recipe = new Dictionary<string, int>();
        int randomNumber;
        foreach (string ing in ingredients){
            randomNumber = Random.Range(0, 3);
            if(randomNumber>0)
            {
                recipeResult+=randomNumber + "x " + ing + "\n";
                recipe[ing] = randomNumber;

            }
        }
        PrintUsedMap(recipe);

        int tableToPlacePizza = Random.Range(0, 4);
        
        if(currentTable!=-1)
        {
            tables[currentTable].SetActive(false);
            tables[tableToPlacePizza].SetActive(true);
            currentTable=tableToPlacePizza;
        }else{
            tables[tableToPlacePizza].SetActive(true);
            currentTable=tableToPlacePizza;
        }


        return recipeResult + "La masa: " + (tableToPlacePizza+1);
    }


    private void PrintUsedMap(Dictionary<string, int> recipe)
    {
        string text = " ";
        foreach (KeyValuePair<string, int> kvp in recipe)
        {
            text += string.Format("{0}: {1}, ", kvp.Key, kvp.Value);
        }
        Debug.Log(text);
    }
}
