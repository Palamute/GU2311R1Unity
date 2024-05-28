using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour 
{ 
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 80f;

    private readonly string HORIZONTAL_AXIS = "Horizontal";
    private float horizontalMove = 0f;
    private bool isPlayerJumping;

    void Update() 
    {
        horizontalMove = Input.GetAxisRaw(HORIZONTAL_AXIS) * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            SetJumpBooleans(true);
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, isPlayerJumping);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SetJumpBooleans(false);
    }

    private void SetJumpBooleans(bool isJumping)
    {
        isPlayerJumping = isJumping;
        animator.SetBool("IsJumping", isJumping);
    }
}
