using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using TMPro;

public class UpgradeJump : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _priceJumpUpgrade;
    [SerializeField] private GameObject _insufficientFunds;
    [SerializeField] private GameObject _successfulPurchase;
    [SerializeField] private TextMeshProUGUI _kolCoinsText;
    public static int UpgradeJumpPrice = 30;
    public static int UpgradeJumpKol = 1;

    public void Start()
    {
        _priceJumpUpgrade.text = UpgradeJumpPrice.ToString();
    }
    public void JumpUpgrade()
    {
        if (UpgradeJumpPrice <= CoinsManager.kolCoins)
        {
            CoinsManager.kolCoins -= UpgradeJumpPrice;
            CoinsManager.CoinsForJump += 2 * UpgradeJumpKol;
            UpgradeJumpKol++;
            _kolCoinsText.text = CoinsManager.kolCoins.ToString();
            UpgradeJumpPrice = UpgradeJumpPrice + (UpgradeJumpPrice/2);
            _priceJumpUpgrade.text = UpgradeJumpPrice.ToString();
            CoinsManager.SaveData();
        }
    }
}    