using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptGameUI : MonoBehaviour
{
    public Text txtScore;
    public Text txtPlayerName;

    void Start()
    {
        txtScore = GetComponent<Text>();
    }

    void Update()
    {
        txtScore.text = "Score: " + GameManager.instance.getScore().ToString();
        txtPlayerName = FindObjectOfType<endGamePopUp>().getName();
    }

    public void btnBack()
    {
        SceneManager.LoadScene(0);
    }

    public void btnQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
