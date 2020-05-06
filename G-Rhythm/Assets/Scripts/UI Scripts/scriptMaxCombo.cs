using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptMaxCombo : MonoBehaviour
{
    public Text txtmaxCombo;

    void Start()
    {
        txtmaxCombo = GetComponent<Text>();
    }

    void Update()
    {
        txtmaxCombo.text = "Max Combo: " + GameManager.instance.getMaxCombo().ToString();
    }
}
