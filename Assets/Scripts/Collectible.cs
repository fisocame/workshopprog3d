using UnityEngine;

public class Collectible : MonoBehaviour
{
   public int scoreValue = 1;
   public AudioClip collectSound;

   private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        ScoreManager.Instance.AddScore(scoreValue);

        if (collectSound)
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }

        Destroy(gameObject);
    }
}
