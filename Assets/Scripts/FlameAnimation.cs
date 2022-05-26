using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{
    public float Speed = 1f;

    //Direction to travel
    public Vector3 Direction = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrackMove());

    }

    IEnumerator TrackMove()
    {
        //Transform component on this object
        Transform ThisTransform = GetComponent<Transform>();

        //Update position in specified direction by speed
        ThisTransform.position += new Vector3(1f, 0f, 0f);
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        //ThisTransform.position += new Vector3(1f, 0f, 0f);

    }
}
