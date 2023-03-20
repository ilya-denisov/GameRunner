using TMPro;
using UnityEngine;

public class ButtonEquipShop : MonoBehaviour
{
    [SerializeField] public int _equipCharacterIndex;
    [SerializeField] public GameObject _buttonUnEquip;
    [SerializeField] public GameObject _buttonEquip;
    [SerializeField] public GameObject[] _buttonsEquip = new GameObject[5];
    [SerializeField] public GameObject[] _buttonsUnEquip = new GameObject[5];
    public void OnButtonEquip()
    {
        _buttonsEquip[CoinsManager.ActiveCharacter].SetActive(false);
        _buttonsUnEquip[CoinsManager.ActiveCharacter].SetActive(true);
        CharacterSkinMenu.ButtonSkinActive[CoinsManager.ActiveCharacter] = 1;
        _buttonUnEquip.SetActive(false);
        _buttonEquip.SetActive(true);
        CoinsManager.ActiveCharacter = _equipCharacterIndex;
        CharacterSkinMenu.ButtonSkinActive[CoinsManager.ActiveCharacter] = 2;
    }
}
