using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {

    private Transform bullet;
    public float speed;

    // Start is called before the first frame update
    void Start() {
        bullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update() {
        bullet.position += Vector3.up * -speed;

        if (bullet.position.y <= -10) {
            Destroy(bullet.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player") {

            Destroy(other.gameObject);
            Destroy(gameObject);
            GameOver.isPlayerDead = true;

        } else if (other.tag == "Base") {

            GameObject playerBase = other.gameObject;
            BaseHealth baseHealth = playerBase.GetComponent<BaseHealth>();
            baseHealth.health -= 1;
            Destroy(gameObject);

        }
    }
}
