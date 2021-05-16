using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosepPanel : MonoBehaviour
{
    public GameObject panelExit;
    public void ExitPanel()
    {
        panelExit.gameObject.SetActive(false);
    }
}
