using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.right = rb.linearVelocity;
    }
}
