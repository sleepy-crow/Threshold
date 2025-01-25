using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private bool _speedy;
    public float speed;

    public float gravityScale;



    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)) {
            modifyVerticalSpeed(gravityScale * -1);
            Debug.Log("Click");
        } else if (Input.GetKeyUp(KeyCode.Mouse0)) {
            modifyVerticalSpeed(gravityScale);
        }
    }

    void modifyVerticalSpeed(float gravityScale) {
        _rb.gravityScale = gravityScale;
        Debug.Log("gravityScale = " + gravityScale);
    }
}
