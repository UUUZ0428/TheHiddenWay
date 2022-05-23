using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Conversation conv;
    public bool isTriggered; 
    private CamSwitcher camSwitcher;
    private Color m_oldColor = Color.white;
    //public static bool IsInputEnabled = true;
    //Rigidbody m_Rigidbody;

    void Start()
    {
        camSwitcher = GetComponent<CamSwitcher>();
        isTriggered = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            //Renderer render = GetComponent<Renderer>();
            //render.material.color = Color.green;
            Cursor.visible = true;

            if (camSwitcher != null)
            {
                camSwitcher.ShowFirstPersonView();
                //IsInputEnabled = false;
            }
            else
            {
                print("camSwitcher not initialized");
            }
            //m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            DialogueManager.StartConversation(conv, camSwitcher);
            isTriggered = true;

        }
        
    }

    void OnTriggerExit(Collider other)
    {
        //Renderer render = GetComponent<Renderer>();
        //render.material.color = m_oldColor;
        if (camSwitcher != null)
        {
            camSwitcher.ShowOverheadView();
            //IsInputEnabled = true;
        }
        else
        {
            print("camSwitcher not initialized");
        }

        //DialogueManager.EndConversation();
        
    }

}
