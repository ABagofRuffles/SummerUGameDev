using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    // Audio to be played when something positive happens
    public AudioSource win_tone;

    // Update is called once per frame
    void Update() {
         // Waits for enter key(Windows) or return key(Mac) to start the game
         if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)) {

            win_tone.Play();

            //Start Coroutine
            StartCoroutine(waitForSound());
        }

    }


    IEnumerator waitForSound() {
        //Wait Until Sound has finished playing
        while (win_tone.isPlaying)
        {
            yield return null;
        }

        //Auidio has finished playing, Load Level 1
        SceneManager.LoadScene("Scene_1");
    }
}
