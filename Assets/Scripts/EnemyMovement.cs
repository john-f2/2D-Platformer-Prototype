/*
 * 
 * Enemy gameObject movement class
 * 
 * 
 * 
 * 
 * @author john
 * 
 * 
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    
    //enemy speed variable
    public int enemySpeed;

    //this enemy will only move in the x direction 
    //thus we can create a variable to only refer to the x axis
    public int xMovementDirection;

    //boolean to see which direction the enemy object is facing 
    //public bool isFacingLeft = false;

    private bool isTouchingGround = false;

    //hitDistance is used to see how far away an object before it will be hit 
    public float hitDistance = 0.9f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //gives the gameObject movement only on the x direction
        //this will move the enemy object as far are the xMovementDirection 
        //currently i have it where it just moves right the entire time
        //i added in the gameObject.GetComponent<Rigidbody2D>().velocity.y to make the object fall down a hole correctly
        BasicEnemyMovement();



    }



    //basic enemy movement function
    //will move one direction until it hits a wall, then flip and move the other way
    //called in update() function
    void BasicEnemyMovement(){
        
        //raycast that will dectect collisions
        //the object could be a wall or the player
        RaycastHit2D hitObject = Physics2D.Raycast(transform.position, new Vector2(xMovementDirection, 0));

        
        if(hitObject.distance < hitDistance){
            FlipEnemy();

        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMovementDirection, gameObject.GetComponent<Rigidbody2D>().velocity.y) * enemySpeed;



    }

    private void FlipEnemy(){

        Debug.Log("the enemy has flipped");
        //if (xMovementDirection < 0.0f)
        //{

        //    GetComponent<SpriteRenderer>().flipX = false;


        //}
        //else if (xMovementDirection > 0.0f)
        //{
        //    GetComponent<SpriteRenderer>().flipX = true;


        //}
        GetComponent<SpriteRenderer>().flipX = false;
        xMovementDirection *= -1;

        //we need to transform the localscale (which will flip the polygoncollider2d)
        //to reflect the sprite change 
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;

        //seting the localScale of the sprite to the new local scale 
        transform.localScale = localScale;

    }




}
