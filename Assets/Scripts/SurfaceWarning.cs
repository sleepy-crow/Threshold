using System;
using UnityEngine;

public class SurfaceWarning : MonoBehaviour
{
    public GameObject warning;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            warning.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            warning.SetActive(false);
        }
    }
}
