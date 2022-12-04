using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
     
    [SerializeField] Text countdownText; 

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1* Time.deltaTime;
        string minutes = ((int) Mathf.Abs(currentTime)/60).ToString();
        string seconds = (Mathf.Abs(currentTime)%60).ToString("f0");
        if (minutes.Length<2)
           minutes = "0" + minutes;
        if (seconds.Length<2)
           seconds = "0" + seconds;
        
        countdownText.text = minutes + ":" + seconds;

        if (currentTime <=0)
        {
            countdownText.text = "-"+ minutes + ":" + seconds;
            countdownText.color = Color.red;
        }
    }
}