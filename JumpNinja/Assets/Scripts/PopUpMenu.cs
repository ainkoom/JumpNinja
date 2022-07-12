using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMenu : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
   // public TMP_Text popUpText;

    public void popUP(string text)
    {
        popUpBox.SetActive(true);
        //popUpText.text = text;
        animator.SetTrigger("pop");
    }

}
