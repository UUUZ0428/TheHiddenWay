using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMenu : MonoBehaviour
{
    public Conversation conv;
    private CamSwitcher camSwitcher;
    GameObject quitMenu;
    private bool isShowing;
    public bool isTriggered;
    // Start is called before the first frame update
    void Start()
    {
        camSwitcher = GetComponent<CamSwitcher>();
        quitMenu = GameObject.FindGameObjectWithTag("Quit");
        isShowing = false;
        quitMenu.SetActive(isShowing);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
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
            DialogueManager.StartConversation(conv, camSwitcher);
            isTriggered = true;

        }
        DialogueManager.StartConversation(conv, camSwitcher);
    }

    void OnTriggerExit(Collider other)
    {
        isShowing = true;
        quitMenu.SetActive(isShowing);
        if (camSwitcher != null)
        {
            camSwitcher.ShowOverheadView();
            //IsInputEnabled = true;
        }
        else
        {
            print("camSwitcher not initialized");
        }
    }
}
