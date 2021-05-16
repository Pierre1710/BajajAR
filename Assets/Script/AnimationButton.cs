using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationButton : MonoBehaviour
{
    public GameObject buttonshow;
    public void ShowHideMenu()
    {
        if (buttonshow != null)
        {
            Animator animator = buttonshow.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("ShowBu");
                animator.SetBool("ShowBu", !isOpen);
            }
        }
    }
}
