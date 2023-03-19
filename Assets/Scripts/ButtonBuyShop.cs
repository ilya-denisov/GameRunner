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
            _buttonUnEquip.SetActive(true);
            _buttonBuy.SetActive(false);
            _kolCoinsInSkinsShop.text = CoinsManager.kolCoins.ToString();
        }
    }
    
    
}
