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
    private void Awake()
    {
        PlayerPrefs.SetFloat("HP", HP);
        DeathScreen.SetActive(false);
    }
    private void Start()
    {
        HP = HPMax;
        Finish();
    }
    private void Update()
    {
        HealthBar.anchorMax = new Vector2(HP / HPMax, 1);
       
        if(HP <= 0)
        {
            Destroy(gameObject);
            DeathScreen.SetActive(true);
            Health.SetActive(false);
            PotionImage.SetActive(false);
            TextCol.SetActive(false);
            Player.SetActive(false);
        }
    }

    private void Finish()
    {
        PlayerPrefs.GetFloat("HP");
    }

    public void TakeDamage(int Damage)
    {
        HP -= Damage;

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
