using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenDetector : MonoBehaviour
{
    public GameObject pizza;
    private bool hasEntered = false;
    public double time = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (hasEntered == false)
        {
            if (other.name.Contains("pizza"))
            {
                Debug.Log("Pizza in oven");
                hasEntered = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Debug.Log("I'm the trigger, someone has left");
        if (other.name.Contains("pizza"))
        {
            hasEntered = false;
            Debug.Log("Pizza left oven");
            Debug.Log(time);
        }
    }

    void Update()
    {
        if(hasEntered)
        {
            time += 0.02;
            // if time > limit: -> change color of blat
        }
    }
}
