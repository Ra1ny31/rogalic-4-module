using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    public float HPMax = 100;
    public float HP = 100;
    public RectTransform HealthBar;

    private void Awake()
    {
        PlayerPrefs.SetFloat("HP", HP);
    }
    private void Start()
    {
        HP = HPMax;
        Finish();
    }
    private void Update()
    {
        HealthBar.anchorMax = new Vector2(HP / HPMax, 1);
        if (Input.GetKeyDown(KeyCode.K))
        {
            HP -= 10;
        }

        if(HP <= 0)
        {
            Destroy(gameObject);
            
        }
       
    }

    private void Finish()
    {
        PlayerPrefs.GetFloat("HP");
    }
}
