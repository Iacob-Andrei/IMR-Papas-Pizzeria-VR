using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreShow : MonoBehaviour
{
    private const int scoreCompute = 93;
    
    [SerializeField] Text scoreText; 
    
    void Start()
    {
        scoreText.text = scoreCompute.ToString();
    }
}
