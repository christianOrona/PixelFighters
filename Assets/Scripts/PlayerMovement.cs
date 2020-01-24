using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool isBlocking = false;

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
            animator.SetBool("isFlying", true);

        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            //Debug.Log("Crouching:" + crouch);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            
        }
        //If normal click 
        if (Input.GetButtonDown("Fire1"))
        {
            //if we are flying use jump attack animation
            if (jump)
                animator.SetTrigger("JumpAttack");
            //if not we are doing normal attack animation
            else
                animator.SetTrigger("isAttacking");
        }
        //If holding right-click Blocks
        if (Input.GetButtonDown("Block"))
        {
            animator.SetBool("isBlocking", true);
            isBlocking = true;
            

        }
        else if (Input.GetButtonUp("Block"))
        {
            animator.SetBool("isBlocking", false);
            isBlocking = false;
        }

        }

   public void onLanding()
    {
        animator.SetBool("isJumping", false);
        animator.SetBool("isFlying", false);
    }


    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        // Move our character
        if(!isBlocking)
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        

    }
}