using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptPauseM : MonoBehaviour
{

    public static bool GamePaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
                FindObjectOfType<GameManager>().playMusic();
            }
            else
            {
                Pause();
                FindObjectOfType<GameManager>().pauseMusic();
            }
        }
    }
    //Resumes Game
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    //Pauses Game
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void btnSongSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void btnQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
