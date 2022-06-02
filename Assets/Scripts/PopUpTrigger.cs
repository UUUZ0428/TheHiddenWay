using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTrigger : MonoBehaviour
{
    //private static NextLevelTrigger instance;
    public Animator anim;
    //GameObject quitMenu;
    //private bool isShowing;

    void Start()
    {
        /**
        Debug.Log("?");
        anim = GetComponent<Animator>();
        Debug.Log("got animator");
        isShowing = false;
        quitMenu = GameObject.FindGameObjectWithTag("Quit");
        quitMenu.SetActive(isShowing);
        **/

    }
    
    void update()
    {
        /**
        Debug.Log("show quit menu");
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("show quit menu");
            isShowing = true;
            quitMenu.SetActive(isShowing);
            //anim.SetBool("isOpen", isShowing);
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

}
