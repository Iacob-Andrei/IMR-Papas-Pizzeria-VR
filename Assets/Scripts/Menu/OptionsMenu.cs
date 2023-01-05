using UnityEngine;
using UnityEngine.Audio;

namespace Menu
{
    public class OptionsMenu : MonoBehaviour
    {
        public static int difficultyIdx = 1;
    
        public AudioMixer audioMixer;
        public void SetVolume(float volume)
        {
            audioMixer.SetFloat("volume", volume);
        }

        public void SetQuality(int qualityIndex)
        {
            QualitySettings.SetQualityLevel(qualityIndex);
        }

        public void SetDifficulty(int difficultyIndex)
        {
            switch (difficultyIndex)
            {
                case 0:
                    difficultyIdx = 1;
                    break;
                case 1:
                    difficultyIdx = 2;
                    break;
                default:
                    difficultyIdx = 3;
                    break;
            }
        }
    }
}
