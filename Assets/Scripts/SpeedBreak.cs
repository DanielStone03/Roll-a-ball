using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBreak : MonoBehaviour
{


    public float Ballspeed;
    public float RealBallSpeed;
    public Rigidbody Ballrb;
    
    // Start is called before the first frame update
    void Start()
    {
        Ballrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ballspeed = Ballrb.angularVelocity.magnitude;
        if (Ballspeed != 0)
        {
            RealBallSpeed = Ballspeed;
        }

    }




    private void OnCollisionEnter(Collider other)
    {
        
    }
}
