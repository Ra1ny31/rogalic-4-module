using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeScript : MonoBehaviour
{
    public GameObject UpgradeScreen;
    public GameObject Player;

    private void Update()
    {
        
    }

    public void UpgradeButton()
    {
        if (GetComponent<CoinScript>().Coin >= 10)
        {
            GetComponent<CoinScript>().Coin -= 10;
            GetComponent<AttackScript>().Damage += 10;
        }
        
    }

    public void UpgradeHPButton()
    {
        if(GetComponent<CoinScript>().Coin >= 10)
        {
            GetComponent<CoinScript>().Coin -= 10;
            GetComponent<PlayerHP>().HP += 10;
        }
        
    }

    public void Back()
    {
        UpgradeScreen.SetActive(false);
        Player.SetActive(true);
        Time.timeScale = 1;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Z) && other.gameObject.tag == "Shop")
        {
            UpgradeScreen.SetActive(true);
            Player.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
