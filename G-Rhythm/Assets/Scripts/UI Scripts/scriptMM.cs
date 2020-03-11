using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMM : MonoBehaviour
{
    /*
     *  Loads scene 1, the song selection.
     */
  
    public void btnStart()
    {
        SceneManager.LoadScene(1);
    }

    public void btnQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void btnBack()
    {
        SceneManager.LoadScene(0);
    }
}
