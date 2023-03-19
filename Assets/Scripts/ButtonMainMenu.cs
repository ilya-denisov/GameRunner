using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonMainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(CharacterMove.ActiveSceneLevel);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
}
