using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneTrigger : MonoBehaviour { 

    public GameObject endGamePopUp;

    void OnTriggerEnter2D(Collider2D other)
    {
        FindObjectOfType<GameManager>().setENDGAME();
        //if (FindObjectOfType<GameManager>().getENDGAME() == true)
        //    showEndPop();
        //SceneManager.LoadScene("EndScreen");
        //GameManager.instance.ENDGAME = true;
}
}
