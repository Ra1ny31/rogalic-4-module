using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public GameObject Wall, Wall2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Wall.SetActive(true);
            Wall2.SetActive(true);
        }

        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Wall.SetActive(false);
            Wall2.SetActive(false);
        }
    }
}
