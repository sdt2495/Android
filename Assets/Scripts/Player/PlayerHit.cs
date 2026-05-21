using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Debug.Log("áŠQ•¨‚ÉÕ“ËI ¨ GameManager ‚É’Ê’m");

            // š •K‚¸ GameManager ‚ğŒÄ‚Ô
            GameManager.Instance.GameOver();
        }
    }
}
