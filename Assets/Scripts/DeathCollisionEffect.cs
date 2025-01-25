using Unity.VisualScripting;
using UnityEngine;

public class DeathCollisionEffect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        Destroy(collision.gameObject);
    }
}
