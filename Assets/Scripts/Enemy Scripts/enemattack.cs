using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemattack : MonoBehaviour
{
    public GameObject Trigger;
    public float Damage = 10f;
    public float CoolDown = 0;


    private void Update()
    {
        CoolDown += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && CoolDown >= 0.5) 
        {
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && CoolDown >= 0.5)
        {
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
        }
    }

    
}
