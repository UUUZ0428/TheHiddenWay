using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupVideo : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!videoPlayer.isPlaying && videoPlayer.frame > 0)
        {
            this.gameObject.SetActive(false);
            print("Video playing finished");

            // load game scene
            SceneManager.LoadScene(0);
        }
    }
}
