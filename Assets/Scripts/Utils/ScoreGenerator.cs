using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class ScoreGenerator : MonoBehaviour
    {
        public static int Score = 0;

        public static void AddToScore(Dictionary<string, int> used, Dictionary<string, int> recipe,  double timeInOven)
        {
            Score += 100 + CompareRecipeToUsed(used, recipe) + CompareTimeInOven(timeInOven);
        }

        private static int CompareRecipeToUsed(Dictionary<string, int> used, Dictionary<string, int> recipe)
        {
            // correct ingredient +20, missing ingredient -10, wrong ingredient -5
            // if all correct bonus 30
            int added = 0, minus = 0;
            foreach (var (ingredient, value) in used)
            {
                if (recipe.ContainsKey(ingredient))
                {
                    if (used[ingredient] == recipe[ingredient])
                    {
                        added += 20 * used[ingredient];
                    }
                    else if (used[ingredient] > recipe[ingredient])
                    {
                        added += 20 * recipe[ingredient];
                        minus += 5 * (used[ingredient] - recipe[ingredient]);
                    }
                    else
                    {
                        added += 20 * used[ingredient];
                        minus += 5 * (recipe[ingredient] - used[ingredient]);
                    }
                }
                else
                {
                    minus += 5 * used[ingredient];
                }
            }
            
            foreach (var (ingredient, value) in recipe)
            {
                if (!used.ContainsKey(ingredient))
                {
                    minus += 10 * recipe[ingredient];
                }
            }

            return (minus == 0) ? 30 + added : added - minus;
        }

        private static int CompareTimeInOven(double time)
        {
            if (time >= 8.5 & time <= 11.5)
            {
                return 100;
            }
            return -20;
        }
    }
}