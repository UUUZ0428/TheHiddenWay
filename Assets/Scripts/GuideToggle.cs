using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideToggle : MonoBehaviour
{
    public GameObject guide;
    private bool isShowing;

    void start()
    {
        guide = GameObject.FindGameObjectWithTag("Guide");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("show guide");
            isShowing = true;
            guide.SetActive(isShowing);
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            isShowing = false;
            guide.SetActive(isShowing);
        }


    }
}
