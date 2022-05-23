using UnityEngine.InputSystem;
using UnityEngine;

public class CamSwitcher : MonoBehaviour
{
    /*
    [SerializeField]
    private InputAction action;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }
    */
    
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    //public GameObject mainCam;
    //public GameObject closupCam;


    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView()
    {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
        //mainCam.SetActive(true);
        //closupCam.SetActive(false);
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;

        //mainCam.SetActive(true);
        //closupCam.SetActive(false);
    }
    

}
