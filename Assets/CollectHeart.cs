
using UnityEngine;

public class CollectHeart : MonoBehaviour
{
    public AudioClip heartSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>();

            if (playerStats != null)
            {
                playerStats.lives++;
                PlayerStats.hasHeart = true;
                AudioManager.Instance.PlayMusicSFX(heartSound);
                Debug.Log("Lives: " + playerStats.lives);
                Destroy(gameObject);
            }
        }
    }
}
