using UnityEngine;

public class ColissionEffect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is create

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

        if(rb.TryGetComponent(out PlayerMovement playerMovement)){

            playerMovement.speed=3f;
        }

    }
}
