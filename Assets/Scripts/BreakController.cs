using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhazeController : MonoBehaviour
{
    public int touches = 0;

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //touches += 1; tests that collision check runs and returns positive

            Destroy(gameObject);
        }
    }


}
