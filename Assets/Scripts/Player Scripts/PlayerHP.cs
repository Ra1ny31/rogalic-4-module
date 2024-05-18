using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    public float HPMax = 100;
    public float HP = 100;
    public RectTransform HealthBar;
    public GameObject DeathScreen;
    public GameObject Health;
    public GameObject TextCol;
    public GameObject PotionImage;
    public GameObject Player;
    public GameObject ImageCoin;
    public GameObject CoinText;
    private void Awake()
    {
        
        DeathScreen.SetActive(false);
    }
    private void Start()
    {
        HP = PlayerPrefs.GetFloat("HP", HP);

        if(HP <= 0)
        {
            HP += 100;
            GetComponent<PotionScript>().SetPotion();
            GetComponent<CoinScript>().SetCoin();
        }
    }
    private void Update()
    {
        HealthBar.anchorMax = new Vector2(HP / HPMax, 1);
        PlayerPrefs.SetFloat("HP", HP);
        if (HP <= 0)
        {
            Destroy(gameObject);
            DeathScreen.SetActive(true);
            Health.SetActive(false);
            PotionImage.SetActive(false);
            TextCol.SetActive(false);
            Player.SetActive(false);
            ImageCoin.SetActive(false);
            CoinText.SetActive(false);
        }
        LoadProgress();
    }

    

    public void TakeDamage(int Damage)
    {
        //if(GetComponent<ShieldScript>().CheckActive == true)
        //{
            //Damage = 0;
        //}
        HP -= Damage;

        PlayerPrefs.SetFloat("HP", HP);
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void LoadProgress()
    {
        PlayerPrefs.GetFloat("HP", HP);
    }

    public void SetHP()
    {
        PlayerPrefs.SetFloat("HP", HP);
        HP = 100;
    }
}
