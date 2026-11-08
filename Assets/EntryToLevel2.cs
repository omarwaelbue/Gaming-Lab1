
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntryToLevel2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && PlayerStats.hasHeart == true)
        {
            SceneManager.LoadScene(2);

            PlayerStats stats = other.GetComponent<PlayerStats>();

            Debug.Log("Lives: " + stats.lives);
            Debug.Log("Health: " + stats.health);
            Debug.Log("Score: " + PlayerStats.score);

            AudioManager.Instance.PlayMusic(AudioManager.Instance.caveMusic);
        }
        else
        {
            FindObjectOfType<LevelManager>().RespawnPlayer();
        }
    }
}
