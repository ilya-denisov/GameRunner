using UnityEngine.Serialization;
using UnityEngine;
using TMPro;

public class AnimatorProxy : MonoBehaviour
{
    [FormerlySerializedAs("Animator")] public Animator _animator;
    [SerializeField] public GameObject[] _characters = new GameObject[5];
    [SerializeField] public Rigidbody _rigidbody;
    [SerializeField] private CapsuleCollider _capsule;
    [SerializeField] public TextMeshProUGUI _text;
    public static int KolCoinsForLevel = 0;
    [SerializeField] private float _speedJump;
    [SerializeField] private float _capsuleHeight;
    [SerializeField] public AudioSource _audioJump;
    
    private static readonly int Jump = Animator.StringToHash("Jump");
    private static readonly int JumpMultiplierSpeed = Animator.StringToHash("JumpMultiplierSpeed");

    public void Start()
    {
        _animator = _characters[CoinsManager.ActiveCharacter].GetComponent<Animator>();
        _text.text = CoinsManager.kolCoins.ToString();
    }

    public void SetSlowJump()
    {
        _animator.SetFloat(JumpMultiplierSpeed, 0.3f);
    }

    public void SetFastJump()
    {
        _animator.SetFloat(JumpMultiplierSpeed, 1f);
    }
    
     public void RigidbodyJump()
    {
        _audioJump.Play();
        _rigidbody.AddForce(transform.up * _speedJump, ForceMode.Impulse);
        _capsule.height = 0.63f;
        Invoke(nameof(SetCapsuleHeight), 1f);
        Debug.Log(KolCoinsForLevel);
        CoinsManager.kolCoins += CoinsManager.CoinsForJump;
        _text.text = CoinsManager.kolCoins.ToString();
    }
     
     private void SetCapsuleHeight()
     {
         _capsule.height = _capsuleHeight;
     }
}
