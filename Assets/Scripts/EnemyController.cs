using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour {

    public static bool playerWon = false;

    private Transform enemeyHolder;
    public float initialSpeed, secondSpeed, thirdSpeed, fourthSpeed;

    public GameObject shot;
    public float fireRate;

    private Scene currentScene;


    // Start is called before the first frame update
    void Start() {
        Time.timeScale = 1;
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemeyHolder = GetComponent<Transform>();

        currentScene = SceneManager.GetActiveScene ();
    }

    void MoveEnemy () {
        enemeyHolder.position += Vector3.right * initialSpeed;

        foreach(Transform enemy in enemeyHolder) {
            if (enemy.position.x < -11 || enemy.position.x > 11) {
                initialSpeed = -initialSpeed;
                enemeyHolder.position += Vector3.down * 0.5f;
                return;
            }

            if (Random.value > fireRate) {
                Instantiate(shot, enemy.position, enemy.rotation);
            }

            // If -3.5 in the y direction is reached, end the game.
            if (enemy.position.y <= -3.5f) {
                GameOver.isPlayerDead = true;
                Time.timeScale = 0;
            }
        }

        if (enemeyHolder.childCount <= 15 && enemeyHolder.childCount > 10)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, secondSpeed);
        }

        if (enemeyHolder.childCount <= 10 && enemeyHolder.childCount > 3) {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, thirdSpeed);
        }

        if (enemeyHolder.childCount <= 3) {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, fourthSpeed);
        }

        if (enemeyHolder.childCount == 0) {
            Time.timeScale = 0;

            if (currentScene.buildIndex + 1 == SceneManager.sceneCountInBuildSettings) {
              playerWon = true;
            } else {
              SceneManager.LoadScene(currentScene.buildIndex + 1);
            }
        }
    }
}
