using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerehodScenes : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
<<<<<<< Updated upstream
        var CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene + 1);


=======
        SceneManager.LoadScene("location 2");
>>>>>>> Stashed changes
        GetComponent<PlayerHP>().LoadProgress();
        GetComponent<PotionScript>().LoadPotion();
        GetComponent<CoinScript>().GetCoin();
    }
}
