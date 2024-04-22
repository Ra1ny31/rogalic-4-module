using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Pause : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject ChoiceScreen;
    public TextMeshProUGUI HP;

    private void Update()
    {
        PauseClick();
    }
    public void PauseClick()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseScreen.SetActive(true);
            HP.enabled = !HP.enabled;
        }

    }

    public void ContinueButton()
    {
        PauseScreen.SetActive(false);
    }

    public void MainMenuButton()
    {
        PauseScreen.SetActive(false);
        ChoiceScreen.SetActive(true);
    }

    public void YesButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void NoButton()
    {
        PauseScreen.SetActive(true);
        ChoiceScreen.SetActive(false);
    }
}
