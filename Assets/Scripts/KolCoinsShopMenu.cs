using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KolCoinsShopMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    public void ReloadKolCoins()
    {
        _text.text = CoinsManager.kolCoins.ToString();
    }
}
