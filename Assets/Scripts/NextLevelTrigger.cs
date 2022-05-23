using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelTrigger : MonoBehaviour
{
    //private static NextLevelTrigger instance;
    public Animator anim;
    private Color m_oldColor = Color.white;

    /**
    public void Awake()
    {
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
        
    }
    **/

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
    /**
    void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;

        anim.SetBool("isOpen", true);
        Cursor.visible = true;
        Debug.Log("trigger");

    }

    void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldColor;

        anim.SetBool("isOpen", false);
        Cursor.visible = false;

    }
    **/
}
