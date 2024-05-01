using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornsScript : MonoBehaviour
{
    public float Damage = 100;
    public PlayerHP HpMain;

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            HpMain.HP -= Damage;
        }
    }
}
