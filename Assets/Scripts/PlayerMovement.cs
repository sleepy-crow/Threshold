using System;
using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D _rb;
    private bool _speedy;
    
    public float speed;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = new Vector2(speed, 0);
    }

    void FixedUpdate()
    {
        if (!_speedy)
            StartCoroutine(SpeedUp());
        _rb.linearVelocity = new Vector2(speed, 0);
    }

    private IEnumerator SpeedUp()
    {
        _speedy = true;
        yield return new WaitForSeconds(3f);
        speed += 0.5f;
        _speedy = false;
    }
}
