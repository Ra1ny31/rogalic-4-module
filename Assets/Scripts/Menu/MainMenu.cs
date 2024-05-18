using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

<<<<<<< Updated upstream
public class MainMenu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("PlotScene");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("PlotScene");
        GetComponent<PlayerHP>().SetHP();
        GetComponent<PotionScript>().SetPotion();
        GetComponent<CoinScript>().Coin = 0;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
=======
public class ButtonContinue : MonoBehaviour
{
   public void Continue()
    {
        SceneManager.LoadScene("location 1");
    }
}
>>>>>>> Stashed changes
