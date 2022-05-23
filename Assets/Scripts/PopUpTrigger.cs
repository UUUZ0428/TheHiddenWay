using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTrigger : MonoBehaviour
{
    //private static NextLevelTrigger instance;
    public Animator anim;
    GameObject guide;




    void Start()
    {
        /**
        anim.SetBool("isOpen", true);
        Cursor.visible = true;
        //anim = GetComponent<Animator>();
        
        if (instance == null)
        {
            instance = this;
            anim = GetComponent<Animator>();
        }
        else
        {
            Destroy(gameObject);
        }
        **/
        
    }
    

    public void appear()
    {
        anim.SetBool("isOpen", true);
        Cursor.visible = true;
    }

    public void disappear()
    {
        anim.SetBool("isOpen", false);
        Cursor.visible = false;
    }

    public void disableGuide()
    {
        
        guide.SetActive(false);
    }

    public void enableGuide()
    {
        guide.SetActive(true);
    }

}
