using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        // Waits for the 'R' Key to be pressed to restart the level
        if (Input.GetKeyDown(KeyCode.R)) {
            PlayerScore.playerScore = 0;
            GameOver.isPlayerDead = false;
            Time.timeScale = 1;

            SceneManager.LoadScene("Scene_1");
        }
    }
}
