using System.Collections.Generic;
using Menu;
using UnityEngine;
using UnityEngine.UI;

namespace Utils
{
    /**
     * Recipe Generator placed on Canvas Object
     */
    public class RecipeGenerator : MonoBehaviour
    {
        private readonly int _difficulty = OptionsMenu.difficultyIdx;
        
        private int _currentTable = -1;
    
        private Dictionary<string, int> _recipe = new();
    
        private readonly List<string> _ingredients = new() { "salami", "olive", "tomato", "mushroom", "mozzarella", "pepper" };
    
        [SerializeField] public Text recipeText; 

        public static int numberOfPizza;
        
        public List<GameObject> tables = new();
        
        private void Start()
        {
            numberOfPizza = SetNumberOfPizza();
            
            recipeText.text = "There are no recipes yet";
            recipeText.text = recipeGenerator();
        }

        private int SetNumberOfPizza()
        {
            return _difficulty switch
            {
                1 => 1,
                2 => 3,
                _ => 4
            };
        }

        public static void UpdateNumberOfPizza(int value)
        {
            numberOfPizza = value;
        }
        
        private int GenerateRandomNumberBasedOnDifficulty()
        {
            return _difficulty switch
            {
                1 => Random.Range(0, 2),
                2 => Random.Range(2, 3),
                _ => Random.Range(3, 5)
            };
        }
    
        public string recipeGenerator()
        {
            var recipeResult = "Recipe:\n";
            _recipe = new Dictionary<string, int>();

            foreach (var ingredient in _ingredients)
            {
                var randomNumber = GenerateRandomNumberBasedOnDifficulty();
                if (randomNumber <= 0) continue;
            
                recipeResult += $"{randomNumber}x {ingredient}\n";
                _recipe[ingredient] = randomNumber;
            }
            //Common.PrintUsedMap(_recipe);

            // var tableToPlacePizza = Random.Range(0, 4);
            var tableToPlacePizza = 0;
        
            if(_currentTable != -1)
            {
                tables[_currentTable].SetActive(false);
                tables[tableToPlacePizza].SetActive(true);
                _currentTable = tableToPlacePizza;
            } else {
                tables[tableToPlacePizza].SetActive(true);
                _currentTable = tableToPlacePizza;
            }

            return $"{recipeResult} La masa: {tableToPlacePizza + 1}";
        }
    }
}
