

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UIElements;
using JetBrains.Annotations;
using Unity.VisualScripting.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed= 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    

    private Rigidbody rb;
    public int count;

    private float movementX;
    private float movementY;

    public float Ballspeed;
    public float RealBallSpeed;
    public float BreakSpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        count= 0;
        SetCountText();
        winTextObject.SetActive(false);
        


    }

    //gets 2d inputs, converts them to variables for use in 3d environment
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector= movementValue.Get<Vector2>();
        movementX= movementVector.x;
        movementY= movementVector.y;
    
    }


    //Check if coin count matches target, display win message
    void SetCountText() //when number is updated:
    {
        countText.text= "Count: " + count.ToString();   //sets number on screen to reflect var "count"

        if (countText.text == "Count: 23")
        {
            winTextObject.SetActive(true);
        }
    }

    //apply force to the player object
    void FixedUpdate()
    {
        Vector3 movement= new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
        Ballspeed = rb.angularVelocity.magnitude;
        if (Ballspeed != 0)
        {
            RealBallSpeed = Ballspeed;
            Debug.Log(RealBallSpeed);
        }
    }

    

    //count up, take away coin
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("BreakWall"))
        {
            if (RealBallSpeed >= BreakSpeed)
            {
                other.gameObject.SetActive(false);
            }
        }
    }
}