using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    // Is the player dead?
    public static bool isPlayerDead = false;

    // Declares the Text to be shown when the player has lost
    private Text gameOver;

    // Audio to be played
    public AudioSource lose_tone;

    // Start is called before the first frame update
    void Start() {
        // Instantiates the text to be used
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
        isPlayerDead = false;
    }

    // Update is called in reference to time
    void FixedUpdate() {
        // If the player has had a bad day,
        // then we should say sorry and make him/her feel better..
        if (isPlayerDead) {
            Time.timeScale = 0;
            gameOver.enabled = true;
            lose_tone.Play();
        }
    }
}
