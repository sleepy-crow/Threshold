using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private bool _speedy;
    public float speed;

    public float VerticalSpeed = 3f;



    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            modifyVerticalSpeed(VerticalSpeed * -1);
            Debug.Log("Click");
        } else if (Input.GetKeyUp(KeyCode.Space)) {
            modifyVerticalSpeed(VerticalSpeed);
        }
    }

    void modifyVerticalSpeed(float vertical) {
        _rb.gravityScale = vertical;
        Debug.Log("gravity = " + _rb.gravityScale);
    }
}
