using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    // Initial EnemyHealth is 1
    public float health = 1;

    // Audio to be played
    public AudioSource explosion;

    // Update is called once per frame
    void Update() {
        // When EnemyHealth is 0, the enemy diez
        if (health <= 0) {
            explosion.Play();

            Destroy(gameObject);
        }
    }
}
