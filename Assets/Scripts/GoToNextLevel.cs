using UnityEngine;
using TMPro;

public class GoToNextLevel : MonoBehaviour
{
    [SerializeField] private AudioSource _audioWinGame;

    public TextMeshProUGUI _textCoinsForLevel;

    public GameObject _levelMenu; 
    

    private void OnCollisionEnter()
    {
        Time.timeScale = 0f;
        _audioWinGame.Play();
        _levelMenu.SetActive(true);
        CharacterMove.ActiveSceneLevel += 1;
    }
}
