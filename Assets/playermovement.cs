using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public CharacterStats stat;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
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