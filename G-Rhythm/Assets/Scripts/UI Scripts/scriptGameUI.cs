using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptGameUI : MonoBehaviour
{
    public Text txtScore;
 
    void Start()
    {
        txtScore = GetComponent<Text>();
    }

    void Update()
    {
        txtScore.text = "Score: " + GameManager.instance.getScore().ToString();
    }
}
