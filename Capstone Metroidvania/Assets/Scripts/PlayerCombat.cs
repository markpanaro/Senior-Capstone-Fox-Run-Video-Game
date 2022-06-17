using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        //Attack with Q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
    }

    void Attack()
    {
        //Play an attack animation
        animator.SetTrigger("Attack");
        //Detect enemies in range of attack
        //Damage in range enemies


    }
}
