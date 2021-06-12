using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller;
    // public coin coin_scr;
    public Animator animator;
    void start()
    {
    }
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    public int points = 0;
    bool jump = false;
    bool crouch = false;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        if (Input.GetButtonDown("crouch"))
        {
            crouch = true;
            animator.SetBool("IsCrouching", true);

        }
        else if (Input.GetButtonUp("crouch"))
        {
            crouch = false;
            animator.SetBool("IsCrouching", false);
        }
    }


    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        animator.SetBool("IsHurt", false);
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}