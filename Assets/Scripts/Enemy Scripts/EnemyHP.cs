using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth;

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    

    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
