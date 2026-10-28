using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerMotor : MonoBehaviour
{
    private Vector2 direction;
    public float acceleration = 10.0f;
    public float jumpForce = 10.0f;
    public Rigidbody2D ridigbody2D;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ridigbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ridigbody2D.AddForce(new Vector2(direction.x,0) * acceleration);
    }


    void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }

    void OnJump()
    {
        ridigbody2D.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
    }

}
