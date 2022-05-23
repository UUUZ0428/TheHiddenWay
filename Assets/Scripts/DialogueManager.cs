using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite;

    private int currentIndex;
    private Conversation currentConv;
    private static DialogueManager instance;
    private Animator anim;
    private CamSwitcher camSwitcher;
    //private DialogueTrigger trigger;

    private void Awake()
    {
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

    public static void StartConversation(Conversation conv, CamSwitcher camSwitcher)
    {
        //initialize dialoguebox
        instance.anim.SetBool("isOpen", true);
        instance.currentIndex = 0;
        instance.currentConv = conv;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";
        instance.camSwitcher = camSwitcher;

        //show conversation
        instance.ReadNext();
    }

    public void ReadNext()
    {

        //to close the conversation when the index reaches its length
        if (currentIndex > currentConv.GetLength())
        {
            instance.anim.SetBool("isOpen", false);
            camSwitcher.ShowOverheadView();
            return;
        }

        speakerName.text = currentConv.GetLineByIndex(currentIndex).speaker.GetName();
        dialogue.text = currentConv.GetLineByIndex(currentIndex).dialogue;
        speakerSprite.sprite = currentConv.GetLineByIndex(currentIndex).speaker.GetSprite();
        currentIndex++;


    }
    /// <summary>
    /// Exit the conversation
    /// </summary>
    public static void EndConversation()
    {
        instance.anim.SetBool("isOpen", false);
        Cursor.visible = false;
    }
}
