﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Empezar : MonoBehaviour
{
    public void ButtonEmpezar()
    {
        SceneManager.LoadScene(SceneManager .GetActiveScene().buildIndex + 1);
    }
}