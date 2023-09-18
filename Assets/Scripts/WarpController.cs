using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpController : MonoBehaviour
{
   public Transform Origin;
   public GameObject Player;







    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
        Player.transform.position = Origin.transform.position;
        }


    }
}
