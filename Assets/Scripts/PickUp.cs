using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    void Update()
    {
       transform.Rotate(new Vector3(15,30,45)* Time.deltaTime);
       //deltaTime is the time spent between frames in seconds, so if more time is spent between frames, it'll move more
    }
}
