using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour {
    // Initial BaseHealth is 2
    public float health = 2;

    // Audio to be played
    public AudioSource base_explosion;

    // Update is called once per frame
    void Update() {
      // When BaseHealth is 0, then the base is not usable anymore
        if (health <= 0) {
            Destroy(gameObject);
        }
    }

    // Executes when the Base is no longer usable
    void OnDestroy() {
        base_explosion.Play();
    }
}
