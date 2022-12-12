using UnityEngine;
using UnityEngine.UI;

namespace Utils
{
    public class CountDownTimer : MonoBehaviour
    {
        public static float currentTime = 0f;
        public static float startingTime = 200f;
     
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
}
