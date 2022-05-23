using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


/// <summary>
/// Reference: https://docs.unity3d.com/ScriptReference/Video.VideoPlayer.html
/// </summary>
public class SceneLoad : MonoBehaviour
{
    //public SpawnPlayer spawnPlayer;
    public static int levelCounter = 0;
    UnityEvent m_MyEvent = new UnityEvent();

    //quit the game when player press esc on keyboard
    void Update()
    {
        /**
        if (Input.GetKeyDown("q"))
        {
            BackToMainMenu();
        }
        **/

        //make cursor visible while the player is pressing left alt
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Debug.Log("leftAlt is pressed");
            Cursor.visible = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            Cursor.visible = false;
            print("alt key was released");
        }
        

    }

    public void StartGame()
    {
        SceneManager.LoadScene(2); // load video scene
        Cursor.visible = false;

        //Add a listener to the new Event. Calls MyAction method when invoked
        //m_MyEvent.AddListener(MyAction);

    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(0); // load second level
        Cursor.visible = false;

    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(3); // load second level
        Cursor.visible = false;

    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
    }

    public void QuitGame()
    {
        Application.Quit();
       
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(1); // load main menu
        Cursor.visible = true;

    }

    

   
}
