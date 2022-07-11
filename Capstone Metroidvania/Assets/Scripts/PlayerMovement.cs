using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public static int totalJumps = 1;	// Total times the player can jump at once
	public static int numJumps = 0;	

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    public static bool canCrouch = false;
    //public static int totalJumps = 1;
    //private int numJumps = totalJumps;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            
       if (Input.GetButtonDown("Jump")) //&& (numJumps>0)) //&& (numJumps > 0))
        {
            if(numJumps<totalJumps){
                jump = true;
                numJumps++;
                animator.SetBool("IsJumping", true);
            }   
                        
        }

        if (Input.GetButtonDown("Crouch") && canCrouch)
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
        numJumps=0;
    }

    public void OnCrouching (bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate ()
    {
        //Move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
            jump = false;
    }
}
