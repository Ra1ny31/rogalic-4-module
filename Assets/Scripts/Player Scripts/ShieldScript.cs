using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            var damage = GetComponent<enemattack>().Damage;
            var Hp = GetComponent<PlayerHP>().HP;

            Hp += damage;
        }
    }

}
