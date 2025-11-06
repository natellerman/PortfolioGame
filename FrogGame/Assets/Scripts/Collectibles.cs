using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect(other.gameObject);
        }
    }

    private void Collect(GameObject player)
    {
        Destroy(gameObject);
    }
}