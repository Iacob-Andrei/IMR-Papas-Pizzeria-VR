using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaDetection : MonoBehaviour
{
    public GameObject pizza;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I'm the trigger, someone has enter");
        if (other.name.Contains("pizza"))
        {
            Debug.Log("Pizza entered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("I'm the trigger, someone has left");
        if (other.tag == "pizza")
        {
            Debug.Log("Pizza left");
        }
    }

}
