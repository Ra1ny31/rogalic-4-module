using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemattack : MonoBehaviour
{
    public float Damage = 10f;
    public float CoolDown = 0;
    


    private void Update()   
    {
       
            CoolDown += Time.deltaTime;

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<PlayerHP>() != null && CoolDown >= 0.3)
        {
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;

        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {

        if (other.gameObject.GetComponent<PlayerHP>() != null && CoolDown >= 0.3)
        {
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
        }
    }


}
