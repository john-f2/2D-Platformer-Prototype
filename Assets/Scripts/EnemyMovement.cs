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
    public bool isFacingLeft = false;

    private bool isTouchingGround = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //gives the gameObject movement only on the x direction
        //this will move the enemy object as far are the xMovementDirection 
        //currently i have it where it just moves right the entire time
        //i added in the gameObject.GetComponent<Rigidbody2D>().velocity.y to make the object fall down a hole correctly
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMovementDirection, gameObject.GetComponent<Rigidbody2D>().velocity.y) * enemySpeed;

    }




}
