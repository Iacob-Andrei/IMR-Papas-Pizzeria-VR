using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientPlacement : MonoBehaviour
{
    private Dictionary<string, int> used = new Dictionary<string, int>();
    private List<string> ingredients = new List<string>
        { "salami", "olive", "tomato", "mushroom", "mozzarella", "pepper" };
    
    [SerializeField] Transform parent;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (ingredients.Contains(collision.gameObject.name))
        {  
            used[collision.gameObject.name] = used.ContainsKey(collision.gameObject.name) ?  used[collision.gameObject.name] + 1 : 1;
            // PrintUsedMap();
            collision.transform.SetParent(parent);
        }
    }

    private void PrintUsedMap()
    {
        string text = " ";
        foreach (KeyValuePair<string, int> kvp in used)
        {
            text += string.Format("{0}: {1}, ", kvp.Key, kvp.Value);
        } 
        Debug.Log(text);
    }
}
