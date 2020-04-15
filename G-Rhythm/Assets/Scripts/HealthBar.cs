﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.minValue = 0;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        if (health >= slider.maxValue) { }
        slider.value = health;

    }
}
