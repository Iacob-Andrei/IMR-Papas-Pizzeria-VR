using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace EndGame
{
    public class ScoreShow : MonoBehaviour
    {
        [SerializeField] Text scoreText; 
    
        void Start()
        {
            scoreText.text = ScoreGenerator.Score.ToString();
        }
    }
}
