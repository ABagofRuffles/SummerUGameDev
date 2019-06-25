using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    private Transform bullet;
    public float speed;

    // Start is called before the first frame update
    void Start() {
        bullet = GetComponent<Transform>();
    }


    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    private void FixedUpdate() {
        bullet.position += Vector3.up * speed;
    }

    void OnTriggerEnter2D (Collider2D other) {
        if (other.tag == "Enemy") {

            GameObject enemy = other.gameObject;
            EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
            enemyHealth.health -= 1;

            Destroy(gameObject);

            PlayerScore.playerScore += 10;

        } else if (other.tag == "Base") {
            Destroy(gameObject);
        }
    }
}
