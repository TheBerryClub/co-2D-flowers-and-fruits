using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour

{

    public CharacterController2D controller;

    public float runspeed = 40f;

    bool crouch = false;

    bool jump = false;

    float HorizontalMove = 0f;
        void Update()
    {

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
