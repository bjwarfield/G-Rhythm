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
    public string curname;
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

    void OnTriggerEnter2D(Collider2D other)
    {
        FindObjectOfType<GameManager>().setENDGAME();
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
        GameManager.instance.setName("CurrentPlayer");
       // name = "Current Player";

    }
    public void btnSubmit()
    {
        hideEndPop();
        EndScore = FindObjectOfType<GameManager>().getScore();
        curname = infieldName.text;
        GameManager.instance.setName(curname);
        SceneManager.LoadScene(2);
    }

    public string getName()
    {
        return name;
    }
}
