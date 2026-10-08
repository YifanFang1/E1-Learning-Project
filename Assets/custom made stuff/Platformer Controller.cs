using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;
    public float jumpForce = 5.0f;
    public float dashStrength = 15.0f;
    public float groundPoundForce = 20.0f;

    float moveX;
    public bool isTouchingGround;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocityX = moveX * moveSpeed;
    }
    
    void OnMove(InputValue value) {
        moveX = value.Get<Vector2>().x;
    }

    void OnJump() {
        if(isTouchingGround) {
            rb.AddForceY(jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")) {
            isTouchingGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")) {
            isTouchingGround = false;
        }
    }

    // left and right arrow keys
    private void OnDash(InputValue value) {
        float moveInput = value.Get<float>();
        moveX += moveInput * dashStrength;
    }

    private void OnGroundPound(InputValue value) {
        if(!isTouchingGround) {
            rb.AddForceY(-groundPoundForce, ForceMode2D.Impulse);
        }
    }
}
