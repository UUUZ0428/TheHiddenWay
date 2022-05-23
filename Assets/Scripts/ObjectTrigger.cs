using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    public Conversation conv;
    private CamSwitcher camSwitcher;
    private Color m_oldColor = Color.white;
    Rigidbody m_Rigidbody;

    void Start()
    {
        camSwitcher = GetComponent<CamSwitcher>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        Cursor.visible = true;

        if (camSwitcher != null)
        {
            camSwitcher.ShowFirstPersonView();
        }
        else
        {
            print("camSwitcher not initialized");
        }

        DialogueManager.StartConversation(conv, camSwitcher);

    }

    void OnTriggerExit(Collider other)
    {
        if (camSwitcher != null)
        {
            camSwitcher.ShowOverheadView();
        }
        else
        {
            print("camSwitcher not initialized");
        }

        DialogueManager.EndConversation();
        Cursor.visible = false;

    }

}
