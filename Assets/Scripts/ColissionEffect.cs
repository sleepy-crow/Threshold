using System;
using Unity.VisualScripting;
using UnityEngine;

public class ColissionEffect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.speedMultiplier=.5f;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.speedMultiplier=1f;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponentInParent<PlayerMovement>().speedMultiplier=0.3f;
        }
            
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponentInParent<PlayerMovement>().speedMultiplier=1f;
        }
    }
}
