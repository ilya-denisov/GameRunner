using System;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class CharacterMove : MonoBehaviour
{
    private float _oldMousePositionX;
    private float _eulerY;
    /*
    [SerializeField] public AudioSource _audioJump;
    */
    public static int ActiveSceneLevel = 1;
    private Vector3 _characterPosition;


    [SerializeField] public GameObject[] _characters = new GameObject[5];
    
    
    [SerializeField] public GameObject _gameLoseMenu;


    [SerializeField] public TextMeshProUGUI _text;


    [SerializeField] private CapsuleCollider _capsule;


    [FormerlySerializedAs("Animator")] public Animator _animator;


    [SerializeField] private float _speed;


    [SerializeField] private float _speedJump;
    public Rigidbody _rigidbody;


    [SerializeField] private float _gap;
    private float _characterPositionZ;
    private int _characterKolPositionZ = 0;



    [FormerlySerializedAs("isMoving")] private bool _isMoving;

    private static readonly int Run = Animator.StringToHash("Run");

    private static readonly int Jump = Animator.StringToHash("Jump");

    private static readonly int JumpMultiplierSpeed = Animator.StringToHash("JumpMultiplierSpeed");
    //public Vector3 toRot;
    //public float smooth;


    private void Start()
    {
        _characterPositionZ = transform.position.z;
        for (int i = 0; i < _characters.Length; i++)
        {
            _characters[i].SetActive(false);
        }
        Time.timeScale = 1f;
        _characters[CoinsManager.ActiveCharacter].SetActive(true);
        _animator = _characters[CoinsManager.ActiveCharacter].GetComponent<Animator>(); 
        _text.text = CoinsManager.kolCoins.ToString();
        _rigidbody.centerOfMass = Vector3.zero;
    }

    private void Update()
    {
        if (_isMoving)
        {
            if (Math.Abs(transform.position.z - _characterPositionZ) <= _gap)
            {
                _characterKolPositionZ++;
                if (_characterKolPositionZ >= 250)
                {
                    _characterKolPositionZ = 0;
                    Time.timeScale = 0f;
                    _gameLoseMenu.SetActive(true);
                }
            }
        }

        _characterPositionZ = transform.position.z;
        
        if(Input.GetMouseButtonDown(0))
        {
            _isMoving = true;
            _animator.SetBool(Run, true);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger(Jump);
            _isMoving = true;
            _animator.SetBool(Run, true);
            /*PlayAudioJump();*/
        }

        if(Input.GetMouseButtonUp(0))
        {
            _animator.SetBool(Run, true);
            _isMoving = true;
        }

        if (transform.position.y < -3)
        {
            Time.timeScale = 0f;
            _gameLoseMenu.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        if (!_isMoving) return;
        Vector3 direction = transform.forward;

        Vector3 velocity = new Vector3(direction.x, 0, direction.z)  * _speed;
        Vector3 worldVelocity = transform.TransformVector(velocity);
        worldVelocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = worldVelocity;
    }

    public void RigidbodyJump()
    {
        _rigidbody.AddForce(transform.up * _speedJump, ForceMode.Impulse);
        _capsule.height = 0.63f;
        Invoke(nameof(SetCapsuleHeight), 1f);
        //KolCoinsForLevel += CoinsManager.CoinsForJump;
        //_text.text = KolCoinsForLevel.ToString();
    }

    public void SetSlowJump()
    {
        _animator.SetFloat(JumpMultiplierSpeed, 0.3f);
    }

    public void SetFastJump()
    {
        _animator.SetFloat(JumpMultiplierSpeed, 1f);
    }

    private void OnCactusEnter(Collider collision)
    {
        _isMoving = false;
        _animator.SetBool(Run, false);

        transform.Translate(1.03f, -1.01f, -12.5f);
    }

    private void SetCapsuleHeight()
    {
        _capsule.height = 1.26f;
    }

    /*private void PlayAudioJump()
    {
        _audioJump.Play();
    }*/
}