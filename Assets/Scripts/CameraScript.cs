/*
 *
 * Camera Script
 * Currently only has player tracking (camera will follow the player)
 * 
 * 
 * @author johnf2
 * 
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    //reference to the player gameObject
    private GameObject player;
    

    //these variables will "clamp" the camera to a certain position 
    //so it doesnt move off to the side
    //hence: xMin is the lowest position the camera can move on the x-plane
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;


    // Use this for initialization
    void Start () {
        //on initialization, sets the player gameObject variable with the actual player GameObject
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    // LateUpdate is called at the end of the update cycle 
    void LateUpdate()
    {
        //Mathf is part of the unity library

        //what clamp does is clamp the value ofthe player's position to be between the min and max
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);

        //the camera poistion changes based on changes from the playerObject 
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);

    }
}
