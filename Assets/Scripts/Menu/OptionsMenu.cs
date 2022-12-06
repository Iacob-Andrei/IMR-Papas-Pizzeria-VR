using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    private int _difficultyIdx = 0;
    
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
                Debug.Log("Difficulty set on: EASY");
                _difficultyIdx = difficultyIndex;
                break;
            case 1:
                Debug.Log("Difficulty set on: MEDIUM");
                _difficultyIdx = difficultyIndex;
                break;
            default:
                Debug.Log("Difficulty set on: HARD");
                _difficultyIdx = difficultyIndex;
                break;
        }
    }
}
