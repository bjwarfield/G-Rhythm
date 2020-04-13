using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class scriptEndPop : MonoBehaviour
{
    public static bool GameEnd = false;
    public GameObject endGamePopUp;
    public Text txtEndScore;
    public string name;

    void Start()
    {
//        
    }
    // Update is called once per frame
    void Update()
    {
        /*
         * if hpBar or end note is true
         */
    //    txtEndScore = GetComponent<Text>();
        //      txtEndScore.text = "Score: " + GameManager.instance.getScore().ToString();
        showEndPop();

    }

    void showEndPop()
    {
        endGamePopUp.SetActive(false);
        Time.timeScale = 1f;
        GameEnd = false;
    }

    void hideEndPop()
    {
        endGamePopUp.SetActive(true);
        Time.timeScale = 0f;
        GameEnd = true;
    }

    public void btnSubmit()
    {
        SceneManager.LoadScene(2);
        hideEndPop();
    }

    public string getName()
    {
        return name;
    }
}
