using TMPro;
using UnityEngine;

public class ButtonBuyShop : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI _price;
    [SerializeField] public GameObject _buttonUnEquip;
    [SerializeField] public GameObject _buttonBuy;
    [SerializeField] public TextMeshProUGUI _kolCoinsInSkinsShop;

    public void OnButtonBuy()
    {
        if (CoinsManager.kolCoins >= int.Parse(_price.text))
        {
            CoinsManager.kolCoins -= int.Parse(_price.text);
            if (int.Parse(_price.text) == 5000)
            {
                CharacterSkinMenu.ButtonSkinActive[1] = 1;
            }
            if (int.Parse(_price.text) == 50000)
            {
                CharacterSkinMenu.ButtonSkinActive[2] = 1;
            }
            if (int.Parse(_price.text) == 250000)
            {
                CharacterSkinMenu.ButtonSkinActive[3] = 1;
            }
            if (int.Parse(_price.text) == 1000000)
            {
                CharacterSkinMenu.ButtonSkinActive[4] = 1;
            }
            _buttonUnEquip.SetActive(true);
            _buttonBuy.SetActive(false);
            _kolCoinsInSkinsShop.text = CoinsManager.kolCoins.ToString();
            CoinsManager.SaveData();
        }
    }
    
    
}
