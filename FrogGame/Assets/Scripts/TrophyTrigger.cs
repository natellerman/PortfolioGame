using UnityEngine;
using UnityEngine.SceneManagement;

public class TrophyTrigger : MonoBehaviour
{
    public string nextSceneName;
    public int points = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);
            Destroy(gameObject);
        }
    }
}
