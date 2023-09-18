
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset= transform.position- player.transform.position;
        //defining offset as difference between camera and player
        //done this way to keep camera consistent with position in editor and to prevent rotation being applied to camera
    }

    void LateUpdate()
    {
        transform.position= player.transform.position+ offset;
        //keeps movement tethered to distance defined as "offset"
    }


}
