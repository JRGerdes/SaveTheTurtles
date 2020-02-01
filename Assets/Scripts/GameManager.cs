﻿using UnityEngine;

public class GameManager : MonoBehaviour
{
    int numberOfTurtlesSaved;
    int trashCollected;
    int numberOfTurtlesAlive;
    public int maxNumberOfTurtles;
    public int maxTrash;
    public static GameManager instance;

    private void Awake() {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        maxNumberOfTurtles = GameObject.FindGameObjectsWithTag("babyTurtle").Length;
        maxTrash = GameObject.FindGameObjectsWithTag("trash").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void collectTrash(){
        trashCollected += 1;
    }
    public void collectTurtle(){
        numberOfTurtlesSaved += 1;
    }
    void gameOver(){
        //Failure
        if(numberOfTurtlesSaved == 0 && numberOfTurtlesAlive == 0 && numberOfTurtlesLeft() == 0){

        }
        //Success
        else if(numberOfTurtlesSaved > 0 && numberOfTurtlesAlive > 0 && numberOfTurtlesLeft() == 0){

        }
    }

    int numberOfTurtlesLeft(){
        return GameObject.FindGameObjectsWithTag("babyTurtle").Length;
    }

    //
    // The following functions are required for the UI script to display
    // the amount of trash and number of turtles correctly.
    //

    public int getTrash() // Returns the amount of trash collected
    {
        return trashCollected;
    }

    public int getTrashMax() // Returns the max amount of trash in the game
    {
        return maxTrash;
    }

    public int getTurtles() // Returns the number of turtles collected
    {
        return numberOfTurtlesSaved;
    }

    public int getTurtlesMax() // Returns the max number of turtles in the game
    {
        return maxNumberOfTurtles;
;
    }
}
