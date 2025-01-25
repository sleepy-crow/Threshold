using Unity.VisualScripting;
using UnityEngine;

public class ColissionEffect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.name);
        if(collider.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.speedMultiplier=.5f;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.speedMultiplier=1f;
        }
    }
}
