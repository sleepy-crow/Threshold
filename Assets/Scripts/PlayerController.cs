using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;

    public float gravityScale;
    public float increment;

    private float _timer = 0f;
    private float delayTime = 0.05f;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        

        _timer += Time.deltaTime;
        if (_timer >= delayTime) {
            if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space)) {
                modifyVerticalSpeed(true);
            } else if (_rb.gravityScale < gravityScale) {
                modifyVerticalSpeed(false);
            }
            _timer = 0f;
        }
        
    }

    void modifyVerticalSpeed(bool isKeyHolding) {
        if(isKeyHolding && _rb.gravityScale > (gravityScale + 5) * -1) {
            _rb.gravityScale -= increment;
        } else {
            _rb.gravityScale += increment;
        }
    }
}
