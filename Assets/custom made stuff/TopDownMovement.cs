using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;
    Vector2 moveDir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        rb.linearVelocity = moveDir * moveSpeed;
    }
    
    void OnMove(InputValue value) {
        moveDir = value.Get<Vector2>();
    }
}
