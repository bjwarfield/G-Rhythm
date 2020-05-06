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
        txtPlayerName = GetComponent<Text>();
    }

    void Update()
    {
        txtScore.text = "Score: " + GameManager.instance.getScore().ToString();
        txtPlayerName.text = GetComponent<scriptEndPop>().getName().ToString();
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
