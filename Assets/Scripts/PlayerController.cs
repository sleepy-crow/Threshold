using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private bool executingCoroutine = false;

    public float gravityScale;
    public float increment;

    private float timer = 0f;
    private float delayTime = 0.05f;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        timer += Time.deltaTime;
        if (timer >= delayTime) {
            if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space)) {
                modifyVerticalSpeed(true);
                Debug.Log("Click");
            } else if (_rb.gravityScale < gravityScale) {
                modifyVerticalSpeed(false);
            }
            timer = 0f;
        }
        
    }

    void modifyVerticalSpeed(bool isKeyHolding) {
        if(isKeyHolding && _rb.gravityScale > (gravityScale + 5) * -1) {
            _rb.gravityScale -= increment;
        } else {
            _rb.gravityScale += increment;
        }
        Debug.Log("gravityScale = " + gravityScale);
    }

}
