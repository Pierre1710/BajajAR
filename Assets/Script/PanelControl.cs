using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControl : MonoBehaviour
{
    public GameObject PanelControls;
    public void ShowHideMenu()
    {
        if (PanelControls != null)
        {
            Animator animator = PanelControls.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("ShowC");
                animator.SetBool("ShowC", !isOpen);
            }
        }
    }
}
