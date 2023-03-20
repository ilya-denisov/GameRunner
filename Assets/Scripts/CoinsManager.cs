using System;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public static int kolCoins = 0;
    public static int ActiveCharacter = 0;
    public static int CoinsForJump = 1;
    public static CoinsManager instance;

    public void OnApplicationFocus(bool hasFocus)
    {
        if(!hasFocus)
            SaveData();
    }
    
    private void OnApplicationQuit()
    {
        SaveData();
    }

    private void Awake()
    {
        if (instance == null)
        {
            LoadData();
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void SaveData()
    {
        PlayerPrefs.SetInt(nameof(kolCoins), kolCoins);
        PlayerPrefs.SetInt(nameof(ActiveCharacter), ActiveCharacter);
        PlayerPrefs.SetInt(nameof(CoinsForJump), CoinsForJump);
        
        for (int i = 0; i < CharacterSkinMenu.ButtonSkinActive.Length; i++)
        {
            PlayerPrefs.SetInt("ButtonSkinActive" + i, CharacterSkinMenu.ButtonSkinActive[i]);
        }
        Debug.Log("Save data");
    }

    public static void LoadData()
    {
        kolCoins = PlayerPrefs.GetInt(nameof(kolCoins), 0);
        ActiveCharacter = PlayerPrefs.GetInt(nameof(ActiveCharacter), 0);
        CoinsForJump = PlayerPrefs.GetInt(nameof(CoinsForJump), 1);
        
        CharacterSkinMenu.ButtonSkinActive[0] = PlayerPrefs.GetInt("ButtonSkinActive" + 0, 2);
        
        for (int i = 1; i < CharacterSkinMenu.ButtonSkinActive.Length; i++)
        {
           
            CharacterSkinMenu.ButtonSkinActive[i] = PlayerPrefs.GetInt("ButtonSkinActive" + i, 0);
        }
        Debug.Log("Load data");
    }
}
