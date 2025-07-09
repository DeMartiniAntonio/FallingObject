using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] private int scoreAmount;
    [SerializeField] private bool isbad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.IncreseScore(scoreAmount);
            if (isbad)
            {
                playerMovement.DecreseLives();
            }
        }
        Destroy(gameObject);
    }
}

