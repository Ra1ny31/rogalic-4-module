using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PotionScript : MonoBehaviour
{
    [SerializeField] private float MaxPotion = 3;
    public int Potion;
    private int AddPotion = 1;
    private PlayerHP HpMain;
    [SerializeField] private TextMeshProUGUI TextPotion;

    private void Start()
    {
        HpMain = GetComponent<PlayerHP>();
        Potion = PlayerPrefs.GetInt("Potion", Potion);
        if(HpMain.HP <= 0)
        {
            Potion = 0;
        }
    }

    private void Update()
    {
        PlayerPrefs.SetInt("Potion", Potion);
        TextPotion.text = Potion.ToString();
        UsePotion();
        LoadPotion();
    }

    private void UsePotion()
    {
        if(Potion >= 1 && Input.GetKeyDown(KeyCode.F) && HpMain.HP <= 90)
        {
            HpMain.HP += 10;
            Potion--;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<Potion>() != null)
        {
            Potion++;
        }
    }

    public void LoadPotion()
    {
        PlayerPrefs.GetInt("Potion", Potion);
    }

    public void SetPotion()
    {
        Potion = 0;
        PlayerPrefs.SetInt("Potion", Potion);
    }
}
