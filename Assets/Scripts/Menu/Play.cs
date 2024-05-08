using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject ExitScreen;
    public GameObject MenuScreen;
    public GameObject SettingScreen;

    public void ClickPlay()
    {
        SceneManager.LoadScene("PlotScene");
    }

   public void Exit()
    {
        MenuScreen.SetActive(false);
        ExitScreen.SetActive(true);
    }

    public void YesButton()
    {
        Application.Quit();
    }

    public void NoButton()
    {
        MenuScreen.SetActive(true);
        ExitScreen.SetActive(false);
    }

    public void Setting()
    {
        SettingScreen.SetActive(true);
        MenuScreen.SetActive(false);
    }
}
