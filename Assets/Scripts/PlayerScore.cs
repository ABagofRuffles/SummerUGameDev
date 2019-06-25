using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

    // Declares and Instatiates the player's score
    public static float playerScore = 0;

    // Declares text to be used to show the player thier score
    private Text scoreText;

    // Start is called before the first frame update
    void Start() {
        // Instantiates the Score text
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        // updates the scoreText to the current score on each frame
        scoreText.text = "Score: " + playerScore;
    }
}
