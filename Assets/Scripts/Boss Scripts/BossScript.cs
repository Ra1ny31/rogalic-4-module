using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public int health = 100;
    public float speed = 3f;

    public int damage = 20;


    
    private void Update()
    {
        MoveBoss();
    }

    private void MoveBoss()
    {
        // ������ �������� �����-������
        transform.Translate(Vector3.right * Mathf.Sin(Time.time) * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            // ������ ��������� ����� ������
            PlayerHP playerHealth = collision.GetComponent<PlayerHP>();
            if (playerHealth != null)
            {

                playerHealth.TakeDamage(damage); 

                playerHealth.TakeDamage(20); 

            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // �������������� �������� ��� ����������� �����, ��������, ���������� ������� ��� ����� ��������
        gameObject.SetActive(false);
    }
}
