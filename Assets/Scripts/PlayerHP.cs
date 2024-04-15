using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    public float HPMax = 100;
    public float HP = 100;
    public TextMeshProUGUI HPText;

    private void Update()
    {
        HPText.text = HP.ToString();
        if (Input.GetKeyDown(KeyCode.K))
        {
            HP -= 10;
        }

        if(HP <= 0)
        {
            Destroy(gameObject);
        }
       
    }
}
