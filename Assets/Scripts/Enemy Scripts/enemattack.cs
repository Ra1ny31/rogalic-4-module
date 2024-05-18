using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemattack : MonoBehaviour
{
    public float Damage = 10f;
    public float CoolDown = 0;
    public Animator animator;


    private void Update()   
    {
       
            CoolDown += Time.deltaTime;

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<PlayerHP>() != null && CoolDown >= 1)
        {
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
            animator.SetTrigger("Attack");
        }

        if (GetComponent<ShieldScript>().shieldCollider.enabled)
        {
            Damage -= 10;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (GetComponent<ShieldScript>().shieldCollider.enabled)
        {
            Damage -= 10;
        }

        if (other.gameObject.GetComponent<PlayerHP>() != null && CoolDown >= 1)
        {
            Damage += 10;
            animator.SetTrigger("Attack");
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        animator.SetTrigger("Idle");
    }


}
