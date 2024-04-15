using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack1 : MonoBehaviour
{
    [SerializeField] private float _attackCooldown;
    [SerializeField] private float _range;
    [SerializeField] private int _damage;
    [SerializeField] private BoxCollider2D BoxCollider;
    [SerializeField] private LayerMask PlayerMask;
    private float _cooldownTimer = Mathf.Infinity;
    void Update()
    {
        _cooldownTimer += Time.deltaTime;

        if (PlayerInSight())
        {
            if(_cooldownTimer >= _attackCooldown)
            {

            }
        }

    }

    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(BoxCollider.bounds.center + transform.right * _range * transform.localScale.x, new Vector3(BoxCollider.bounds.size.x * _range, BoxCollider.bounds.size.y, BoxCollider.bounds.size.z) , 0, Vector2.left, 0, PlayerMask);
        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(BoxCollider.bounds.center + transform.right * _range * transform.localScale.x, new Vector3(BoxCollider.bounds.size.x * _range, BoxCollider.bounds.size.y, BoxCollider.bounds.size.z));
    }
}
