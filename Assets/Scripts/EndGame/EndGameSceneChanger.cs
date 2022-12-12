using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EndGame
{
    public class EndGameSceneChanger : MonoBehaviour
    {

        public static void GetToFinalSceneWhenThereIsNoPizza()
        {
            SceneManager.LoadScene(2);
        }
    }
}
