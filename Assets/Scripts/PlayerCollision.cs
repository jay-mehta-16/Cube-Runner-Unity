using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public Rigidbody rb;

    // Reference to the scripts to disable.
    public PlayerMovement movementScript;
    public ObstacleSpawner obstacleSpawner;

    // Restart Delay
    public float RestartDelay;

    void OnCollisionEnter (Collision collisionInfo)
    {
        // Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "obstacle") {
            movementScript.enabled = false;
            obstacleSpawner.enabled = false;

            Debug.Log("Game Over Man!");

            Invoke("Restart" , RestartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
