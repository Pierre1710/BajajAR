using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScala : MonoBehaviour
{
    public GameObject PanelScalar;
    public void ShowHideMenu()
    {
        if (PanelScalar != null)
        {
            Animator animator = PanelScalar.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Shows");
                animator.SetBool("Shows", !isOpen);
            }
        }
    }
}