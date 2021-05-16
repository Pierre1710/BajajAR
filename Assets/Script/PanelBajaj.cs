using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBajaj : MonoBehaviour
{
    public GameObject PanelBajajs;
    public void ShowHideMenu()
    {
        if (PanelBajajs!= null)
        {
            Animator animator = PanelBajajs.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Showb");
                animator.SetBool("Showb", !isOpen);
            }
        }
    }
}
