using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptSS : MonoBehaviour
{
    public void btnBack()
    {
        SceneManager.LoadScene(0);
    }

    public void btnSong1()
    {
        SceneManager.LoadScene(2);
    }
}
