﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelButtonCom : MonoBehaviour
{
    public GameObject Panel;
    int i;
    public void ShowhidePanel()
    {
        i++;
        if (i % 2 == 1)
        {
            Panel.gameObject.SetActive(false);
        }
        else
        {
            Panel.gameObject.SetActive(true);
        }

    }
}