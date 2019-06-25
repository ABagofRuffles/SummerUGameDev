using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWins : MonoBehaviour {
    private Text winText;

    public AudioSource win_tone;


    // Start is called before the first frame update
    void Start() {
      winText = GetComponent<Text>();
      winText.enabled = false;
    }

    // Update is called once per frame
    void Update() {
      if (EnemyController.playerWon) {
          winText.enabled = true;

          win_tone.Play();
          EnemyController.playerWon = false;
      }
    }
}
