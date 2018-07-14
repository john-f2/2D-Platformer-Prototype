/*
 * 
 * 
 * Player life script, will contain the player's health 
 * and currently checks if the player has died or not
 * 
 * 
 * @author johnf2
 * 
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour {
    
    //player health variable
    public int playerHealth;

    //player death boolean 
    public bool hasDied = false;


	// Use this for initialization
	void Start () {
        //initializes the player's health to 1
        playerHealth = 1;


		
	}
	
	// Update is called once per frame
    //LateUpdate is called at the end of the update cycle 
	void LateUpdate () {
        
        //initial implementation of player fall death 
        //if the player position is less than -5, reload the scene 
        if(gameObject.transform.position.y < -10){

            SceneManager.LoadScene("PrototypeScene_1");
            
        }
		
	}
}
