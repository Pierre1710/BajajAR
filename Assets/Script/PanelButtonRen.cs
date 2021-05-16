using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelButtonRen : MonoBehaviour
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
