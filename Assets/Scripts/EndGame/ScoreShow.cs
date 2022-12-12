using UnityEngine;
using UnityEngine.UI;

namespace EndGame
{
    public class ScoreShow : MonoBehaviour
    {
        private const int scoreCompute = 93;
    
        [SerializeField] Text scoreText; 
    
        void Start()
        {
            scoreText.text = scoreCompute.ToString();
        }
    }
}
