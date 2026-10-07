using UnityEngine;

public class BallBounce : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float bounceForce = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        // if(other.gameObject.CompareTag("Ground")) {
        //     rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        // }
    }
}
