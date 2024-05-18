using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemattack : MonoBehaviour
{
    public float Damage = 10f;
    public float CoolDown = 0;
<<<<<<< Updated upstream
    public Animator animator;
=======
    
>>>>>>> Stashed changes


    private void Update()   
    {
       
            CoolDown += Time.deltaTime;

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
<<<<<<< Updated upstream
        if(other.gameObject.GetComponent<PlayerHP>() != null && CoolDown >= 1)
        {
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
            animator.SetTrigger("Attack");
        }

        if (GetComponent<ShieldScript>().shieldCollider.enabled)
        {
            Damage -= 10;
=======
        if(other.gameObject.GetComponent<PlayerHP>() != null && CoolDown >= 0.3)
        {
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;

>>>>>>> Stashed changes
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
<<<<<<< Updated upstream
        if (GetComponent<ShieldScript>().shieldCollider.enabled)
        {
            Damage -= 10;
        }

        if (other.gameObject.GetComponent<PlayerHP>() != null && CoolDown >= 1)
        {
            Damage += 10;
            animator.SetTrigger("Attack");
=======

        if (other.gameObject.GetComponent<PlayerHP>() != null && CoolDown >= 0.3)
        {
>>>>>>> Stashed changes
            CoolDown = 0;
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
        }
    }

<<<<<<< Updated upstream
    private void OnCollisionExit(Collision collision)
    {
        animator.SetTrigger("Idle");
    }

=======
>>>>>>> Stashed changes

}
