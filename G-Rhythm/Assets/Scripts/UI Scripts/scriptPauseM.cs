using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptPauseM : MonoBehaviour
{

    public static bool GamePaused = false;
    public GameObject pauseMenuUI;
    public AudioSource curAudio;

    void Start()
    {
        curAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    //Resumes Game
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        curAudio.Play();            //For Audio
        GamePaused = false;
    }
    //Pauses Game
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        curAudio.Pause();           //For Audio
        GamePaused = true;
        curAudio.Pause();
    }

    public void btnSongSelect()
    {
        curAudio.Stop();            //To reset audio
        SceneManager.LoadScene(1);
    }

    public void btnQuit()
    {
        curAudio.Stop();
        Debug.Log("Quit");
        Application.Quit();
    }
}
