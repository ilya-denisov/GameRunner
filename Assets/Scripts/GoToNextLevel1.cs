using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel1 : MonoBehaviour
{
    
    public void ToNextLevel()
    {
        if (CharacterMove.ActiveSceneLevel >= 4)
        {
            CharacterMove.ActiveSceneLevel = UnityEngine.Random.Range(1, 5);
        }
        // else
        // {
        //     CharacterMove.ActiveSceneLevel += 1;
        // }
        Time.timeScale = 1f;
        SceneManager.LoadScene(CharacterMove.ActiveSceneLevel);
    }
}
