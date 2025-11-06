using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string nextSceneName = "NextScene"; // Name of the next scene to load

    // This method is triggered when another collider enters the trigger collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided with the box is the player
        if (other.CompareTag("Player"))
        {
            // Check if the player is on top of the box (player's Y position is greater than the box's Y position)
            if (other.transform.position.y > transform.position.y)
            {
                // Load the next scene
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}