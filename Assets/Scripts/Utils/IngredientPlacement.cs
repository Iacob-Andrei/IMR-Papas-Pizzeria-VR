using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class IngredientPlacement : MonoBehaviour
    {
        public Dictionary<string, int> used = new();
    
        private List<string> ingredients = new() { "salami", "olive", "tomato", "mushroom", "mozzarella", "pepper" };
    
        [SerializeField] Transform parent;
    
        private void OnCollisionEnter(Collision collision)
        {
            if (!ingredients.Contains(collision.gameObject.name.Split(" ")[0])) return;

            used[collision.gameObject.name] = used.ContainsKey(collision.gameObject.name) ?  used[collision.gameObject.name] + 1 : 1;
            
            collision.transform.SetParent(parent);
            
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.isKinematic = true;
            BoxCollider box = collision.gameObject.GetComponent<BoxCollider>();
            Destroy(box);
        }
    }
}
