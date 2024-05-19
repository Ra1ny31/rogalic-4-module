using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
    public int Coin;
    public TextMeshProUGUI CoinText;

    private void Start()
    {
        Coin = PlayerPrefs.GetInt("Coin", Coin);
    }
    private void Update()
    {
        CoinText.text = Coin.ToString();

        PlayerPrefs.SetInt("Coin", Coin);

        GetCoin();

        
    }

    public void SetCoin()
    {
        PlayerPrefs.SetInt("Coin", Coin);
        Coin = 0;
    }

    public void GetCoin()
    {
        PlayerPrefs.GetInt("Coin", Coin);
    }

}
