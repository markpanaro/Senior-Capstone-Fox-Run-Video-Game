using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDoubleJump : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            CharacterController2D.totalJumps = 2;
            Destroy(gameObject);
        }
    }
}
