using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class scriptEndPop : MonoBehaviour
{
    public static bool GameEnd = false;
    public GameObject endGamePopUp;
    public int EndScore;
    public string name;
    public InputField infieldName;    

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<GameManager>().getENDGAME()==true)
               showEndPop();

    }

    void showEndPop()
    {
        endGamePopUp.SetActive(true);
        Time.timeScale = 0f;
        GameEnd = true;
    }

    void hideEndPop()
    {
        endGamePopUp.SetActive(false);
        Time.timeScale = 1f;
        GameEnd = false;
    }
    
    public void btnSkip()
    {
        hideEndPop();
        SceneManager.LoadScene(2);

    }
    public void btnSubmit()
    {
        hideEndPop();
        EndScore = FindObjectOfType<GameManager>().getScore();
        name = infieldName.text;
        SceneManager.LoadScene(2);
    }

    public string getName()
    {
        return name;
    }
}
