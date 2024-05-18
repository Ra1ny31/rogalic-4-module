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
<<<<<<< Updated upstream
        PlayerPrefs.SetInt("Coin", Coin);
=======
        GetCoin();
>>>>>>> Stashed changes
        
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
