using UnityEngine;

public class DangerCactus : MonoBehaviour
{
    public GameObject _gameLoseMenu;


    private void OnCollisionEnter()
    {
        Time.timeScale = 0f;
        _gameLoseMenu.SetActive(true);
    }
}
