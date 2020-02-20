using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour

{

    public CharacterController2D controller;

    public float runspeed = 40f;

    public float Speed;
    public float jumpForce;

    private Rigidbody2D rb;

    bool crouch = false;

    private Animator anim;

    bool jump = false;

    float HorizontalMove = 0f;

    float Rigidbody2D;

    float velocity;

    float magnitude;
    




    void start ()
    {
        anim = GetComponent<Animator>();

        

    }
        void Update()

    {

        float moveInput = Input.GetAxisRaw("horizontal");

        
        

          if (moveInput == 0)
        
        {
            anim.SetBool("IsRunning", false);

        }
        else
        {
            anim.SetBool("IsRunning", true);
        }
        






        HorizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        if (Input.GetButtonDown("jump"))
        {
            
            jump = true;
            print ("jumped");

        }

        if(Input.GetButtonDown("crouch"))
        {
            crouch = true;

        } else if (Input.GetButtonUp("crouch"))
        {
            crouch = false;
        }


        
        
    }

    void FixedUpdate ()
    {
        //move charecter
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
