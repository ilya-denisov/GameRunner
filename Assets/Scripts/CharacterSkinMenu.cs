using UnityEngine;
using UnityEngine.Serialization;

public class CharacterSkinMenu : MonoBehaviour
{
    [SerializeField] public GameObject[] _buttonBuy = new GameObject[5];
    [SerializeField] public GameObject[] _buttonEquip = new GameObject[5];
    [SerializeField] public GameObject[] _buttonUnEquip = new GameObject[5];
    public static readonly int[] ButtonSkinActive = new int[5] { 2, 0, 0, 0, 0 };
    
    public void ActiveSkinMenu()
    {
        for (var i = 0; i < ButtonSkinActive.Length; i++)
        {
            Debug.Log(ButtonSkinActive[i]);
            
            if(ButtonSkinActive[i] == 0)
            {
                _buttonBuy[i].SetActive(true);
                _buttonEquip[i].SetActive(false);
                _buttonUnEquip[i].SetActive(false);
                Debug.Log("if0");
            }
            if(ButtonSkinActive[i] == 1)
            {
                _buttonBuy[i].SetActive(false);
                _buttonEquip[i].SetActive(true);
                _buttonUnEquip[i].SetActive(false);
                Debug.Log("if1");
            }
            if(ButtonSkinActive[i] == 2)
            {
                _buttonBuy[i].SetActive(false);
                _buttonEquip[i].SetActive(false);
                _buttonUnEquip[i].SetActive(true);
                Debug.Log("if2");
            }
            Debug.Log("for");
        }
    }
}
