using UnityEngine;
using System.Collections;

public class DATACoins : MonoBehaviour {

    public static int Money;
    private int MoneyShop;

    // Use this for initialization
	void Start () {
        MoneyShop += Money;
	}
	
	// Update is called once per frame
	void Update () {
        print(MoneyShop);
	}
}
