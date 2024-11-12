using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{   

    //The score is decided using the how much you will spend time in the Game

    //display the score
    public Text scoreText;
    //keep the score of the player 
    private float score;

    // Update is called once per frame
    void Update()
    {
        //First check if the player is alive or not.
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
}
