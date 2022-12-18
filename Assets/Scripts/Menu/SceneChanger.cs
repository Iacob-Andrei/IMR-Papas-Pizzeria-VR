using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class SceneChanger : MonoBehaviour
    {
        /*
         * Scenes indexes have been set in Build Setting Window
         * Scenes/Menu          - Idx 0
         * Scenes/Game          - Idx 1
         * Scenes/EndGameScene  - Idx 2
         */
        
        public void BackToMain()
        {
            SceneManager.LoadScene(0);
        }
        
        public void GoToGameScene()
        {
            SceneManager.LoadScene(1);
        }
        
        public static void GetToFinalScene()
        {
            SceneManager.LoadScene(2);
        }
    }
}