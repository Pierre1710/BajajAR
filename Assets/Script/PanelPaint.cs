using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPaint : MonoBehaviour
{
    public GameObject PanelPainting;
    public void ShowHideMenu()
    {
        if (PanelPainting != null)
        {
            Animator animator = PanelPainting.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
        }
    }
}