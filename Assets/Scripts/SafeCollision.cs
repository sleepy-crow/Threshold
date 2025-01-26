using System.Collections;
using UnityEngine;

public class SafeCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.speed *= -1;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerMovement playerMovement))
        {
            StartCoroutine(HandleCollisionExit(playerMovement));
        }
    }

    private IEnumerator HandleCollisionExit(PlayerMovement playerMovement)
    {
        float delayTime = 0.5f;
        float currentPositiveSpeed = playerMovement.speed * -1;

        yield return new WaitForSeconds(delayTime);
        while (playerMovement.speed < currentPositiveSpeed) {
            playerMovement.speed += 1;
        }
        
    }
}
