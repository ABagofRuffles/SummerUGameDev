using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDefeat : MonoBehaviour {
    // Declares BaseHolder reference
    private Transform playerBase;

    // Start is called before the first frame update
    void Start() {
        // Instantiates BaseHolder reference so that we can actually use it
        // to count the number of bases we have
        playerBase = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        // Once all the bases are gone, the player loses the game :(
        if (playerBase.childCount == 0) {
            GameOver.isPlayerDead = true;
        }
    }
}
