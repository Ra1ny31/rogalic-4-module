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
    }

    private void Update()
    {
        TextPotion.text = Potion.ToString();
        UsePotion();
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
}
