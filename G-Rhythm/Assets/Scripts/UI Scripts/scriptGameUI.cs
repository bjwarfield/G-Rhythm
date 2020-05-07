using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scriptGameUI : MonoBehaviour
{
    public Text txtScore;
    public Text txtName;

    void Start()
    {
        txtScore = GetComponent<Text>();
        //txtName = GetComponent<Text>();
    }

    void Update()
    {
        txtScore.text = "Score: " + GameManager.instance.getScore().ToString();
        txtName.text = GameManager.instance.getName().ToString();
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
