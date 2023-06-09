using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void UseRestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (CharacterMove.ActiveSceneLevel != SceneManager.GetActiveScene().buildIndex)
        {
            CharacterMove.ActiveSceneLevel -= 1;
        }
    }
}

