using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    float movementX = 0;
    float movementY = 0;
    [SerializeField] float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        float xMoveDistance = movementX * speed * Time.fixedDeltaTime;
        float yMoveDistance = movementY * speed * Time.fixedDeltaTime;

        transform.position = new Vector2(transform.position.x + xMoveDistance, transform.position.y + yMoveDistance);
    }

    void OnMove(InputValue value) {
        Vector2 v = value.Get<Vector2>();
        // Debug.Log(v);
        movementX = v.x;
        movementY = v.y;
        // Debug.Log(movementX);
        // Debug.Log(movementY);
    }
}
