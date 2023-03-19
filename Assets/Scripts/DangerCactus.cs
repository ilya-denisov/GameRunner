using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerCactus : MonoBehaviour
{
    public GameObject _gameLoseMenu;


    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0f;
        _gameLoseMenu.SetActive(true);
    }
}
