using UnityEngine;
using UnityEngine.SceneManagement;

namespace EndGame
{
    public class BackToMainMenu : MonoBehaviour
    {
        public void BackToMain()
        {
            SceneManager.LoadScene(0);
        }
    }
}
