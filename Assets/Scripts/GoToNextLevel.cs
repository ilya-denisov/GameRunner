using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class GoToNextLevel : MonoBehaviour
{
    [SerializeField] private AudioSource _audioWinGame;

    public TextMeshProUGUI _textCoinsForLevel;

    public GameObject _levelMenu; 
    

    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0f;
        _audioWinGame.Play();
        _levelMenu.SetActive(true);
    }
}
