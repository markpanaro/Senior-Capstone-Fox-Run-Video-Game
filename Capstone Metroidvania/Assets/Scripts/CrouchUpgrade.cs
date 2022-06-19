using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchUpgrade : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            PlayerMovement.canCrouch = true;
            Destroy(gameObject);
        }
    }
}
