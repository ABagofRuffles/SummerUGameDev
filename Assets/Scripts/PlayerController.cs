using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Transform player;
    public float speed;
    public float maxBound, minBound;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    public float nextFire;

    public AudioSource explosion;


    // Start is called before the first frame update
    void Start() {
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        float h = Input.GetAxis("Horizontal");

        if (player.position.x < minBound && h < 0) {
            h = 0;
        } else if (player.position.x > maxBound && h > 0) {
            h = 0;
        }

        player.position += Vector3.right * h * speed;

    }

    private void Update() {
        if (Input.GetButton("Fire1") && Time.time > nextFire) {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }

    void OnDestroy() {
      if (GameOver.isPlayerDead) {
        explosion.Play();
      }
    }
}
