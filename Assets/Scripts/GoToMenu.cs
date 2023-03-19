using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public void OnGoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    
}
