using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody2D rb;
    private bool _speedy;
    private bool _end;
    
    public float speed;

    public string nextLevel;
    public float time;
    void Start()
    {
        rb.linearVelocity = new Vector2(speed, 0);
    }

    void FixedUpdate()
    {
        if (!_speedy && !_end)
            StartCoroutine(SpeedUp());
        rb.linearVelocity = new Vector2(speed, 0);
    }

    private IEnumerator SpeedUp()
    {
        _speedy = true;
        yield return new WaitForSeconds(3f);
        speed += 0.5f;
        _speedy = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EndStop"))
        {
            rb.linearVelocity = Vector2.zero;
            StartCoroutine(ChangeLevel());
        }
    }

    private IEnumerator ChangeLevel()
    {
        Debug.Log("Loading" + nextLevel + "in" + time);
        yield return new WaitForSeconds(time);
        Next();
    }
    
    private void Next()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
