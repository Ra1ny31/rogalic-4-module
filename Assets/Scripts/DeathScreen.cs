using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public PlayerHP HP;
    public GameObject Objects;
    public GameObject UISceneDeath;

    private void Update()
    {
        if(HP.HP == 0)
        {
            UISceneDeath.SetActive(true);
            Objects.SetActive(false);
        }
    }

    public void Restart()
    {
        var CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
