using UnityEngine;
using System.Collections;

public class DATACoins : MonoBehaviour {

    public static int Money;
    private static int MoneyShop;
    private int saveMoney;

    void Awake()
    {
        PlayerPrefs.GetInt("moneyShop");
        saveMoney = PlayerPrefs.GetInt("moneyShop");
        MoneyShop += Money;
        Debug.Log(MoneyShop + " dinheiro do jogo");
    }

    void Start()
    {
        if(saveMoney > 0)
        {
            MoneyShop += saveMoney;
        }
        Debug.Log(MoneyShop + " dinheiro do jogo somado");
    }
	
}
