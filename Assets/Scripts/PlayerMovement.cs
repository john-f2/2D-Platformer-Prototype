﻿/*
 * 
 * 
 * PlayerMovement Script
 * Used to give movement to the player object 
 * 
 * 
 * 
 * @author johnf2
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    //public variables for the player characters
    public int playerSpeed = 5;



    public int playerJumpPower = 1250;

    //movement on the X plane
    private float xMovement;

    //member variable to know if the player is on the ground
    public bool isGrounded;




    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        MovePlayer();
	}


    //player movement

    void MovePlayer(){

        //Controls
        //set the movement on the X plane by getting the input from GetAxis 
        xMovement = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }


        //Direction
        //Flips player depending on which direction the player is moving 
        if (xMovement < 0.0f )
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (xMovement > 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }

        //allows the player to move left or right 
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMovement * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);


        



    }


    //Jumping function
    void Jump(){
        //this GetComponent function will make the player "jump"
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;

    }


    //Listener function 
    //when the player gameObject collides with an object this function will call 
    private void OnCollisionEnter2D(Collision2D col)
    {
        //simple way to see what the player object has hit
        Debug.Log("Player has collided with " + col.collider.name);

        //checks if the object the plaer collided with is, has the ground tag 
        //allows the player to jump again
        if (col.gameObject.tag == "ground"){
            isGrounded = true;
        }


    }




}
