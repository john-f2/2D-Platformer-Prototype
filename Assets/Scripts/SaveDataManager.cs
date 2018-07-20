using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//saving the data libraries 
using System;
using System.IO;
//this library will convert our data to binary 
using System.Runtime.Serialization.Formatters.Binary;



//using PlayerPrefs 
//example to use later
//PlayerPrefs.SetInt("HighScore", 10);
//gets the value 
//PlayerPrefs.GetInt("HighScore", 10);

/**
 * 
 * 
 * SaveDataManager class
 * used to save game data 
 * data is represented as a class and is saved as binary to a file  
 * 
 * 
 * @author(johnf2)
 * 
 */ 
public class SaveDataManager : MonoBehaviour {


    //static representation of class
    public static SaveDataManager dataManager;


    // Update is called once per frame
    void Update () {
		
	}


    public void SaveDataToFile(){

    }

    public void LoadDataFromFile(){

        

    }


}

/**
 * 
 * GameData class used to
 * represent the game data which will be saved
 * this is the class to be stored and loaded on file 
 * 
 *
 */
class GameData{

    //private member variables that will be saved
    //this will be collectables, lifes, etc. 



}

