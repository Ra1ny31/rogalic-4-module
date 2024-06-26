using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Pause : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject ChoiceScreen;
    public GameObject HP;
    public GameObject Player;
    public GameObject PotionColText;
    public GameObject PotionImage;
    public GameObject ImageCoin;
    public GameObject CoinText;
    //public TextMeshProUGUI HP;

    private void Update()
    {
        PauseClick();
    }
    public void PauseClick()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseScreen.SetActive(true);
            HP.SetActive(false);
            Player.SetActive(false);
            PotionImage.SetActive(false);
            PotionColText.SetActive(false);
            ImageCoin.SetActive(false);
            CoinText.SetActive(false);
            Time.timeScale = 0;
            //HP.enabled = !HP.enabled;
        }

    }

    public void ContinueButton()
    {
        PauseScreen.SetActive(false);
        HP.SetActive(true);
        Player.SetActive(true);
        PotionImage.SetActive(true);
        PotionColText.SetActive(true);
        ImageCoin.SetActive(true);
        CoinText.SetActive(true);
        Time.timeScale = 1;
    }

    public void MainMenuButton()
    {
        PauseScreen.SetActive(false);
        ChoiceScreen.SetActive(true);
    }

    public void YesButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NoButton()
    {
        PauseScreen.SetActive(true);
        ChoiceScreen.SetActive(false);
    }
}
