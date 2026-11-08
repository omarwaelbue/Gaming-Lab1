
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioClip coin;
    public AudioClip coin2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStats.score++;

            AudioManager.Instance.PlayRandomSFX(coin, coin2);

            Debug.Log("Score: " + PlayerStats.score);

            Destroy(gameObject);
        }
    }
}
