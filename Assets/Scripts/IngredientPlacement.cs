using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientPlacement : MonoBehaviour
{
    private List<string> used = new List<string>();

    private List<string> ingredients = new List<string>
        { "salam", "olive", "tomato", "mushroom", "mozzarella", "pepper" };
    
    [SerializeField] Transform parent;
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.parent.gameObject.name);
        if (ingredients.Contains(collision.gameObject.name))
        {
            used.Add(collision.gameObject.name);
            Debug.Log(string.Join(", ", used));

            collision.transform.SetParent(parent);
        }
    }
}
