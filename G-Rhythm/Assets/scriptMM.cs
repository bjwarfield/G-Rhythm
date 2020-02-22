using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMM : MonoBehaviour
{

    public void btnStart()
    {
        SceneManager.LoadScene(1);
    }

    public void btnQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
        SceneManager.LoadScene("MainMenu");
    }

    public void btnBack()
    {
        SceneManager.LoadScene(0);
    }

    public void btnSettings()
    {
        SceneManager.LoadScene("SettingMenu");
    }
}
