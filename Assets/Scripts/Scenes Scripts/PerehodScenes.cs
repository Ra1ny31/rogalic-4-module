using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerehodScenes : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("location 2");
        GetComponent<PlayerHP>().LoadProgress();
        GetComponent<PotionScript>().LoadPotion();
        GetComponent<CoinScript>().GetCoin();
    }
}
