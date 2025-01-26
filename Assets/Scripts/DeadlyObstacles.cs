using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadlyObstacles : MonoBehaviour
{
    public GameObject bubble;
    public PlayerMovement movement;
    public PlayerController player;
    public AudioSource au;
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DeadEnd());
        }
    }

    private IEnumerator DeadEnd()
    {
        player.enabled = false;
        movement.speedMultiplier = 0f;
        bubble.SetActive(false);
        au.Play();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameOver");
    }
}
