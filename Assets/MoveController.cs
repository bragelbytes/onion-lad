using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    private float xInput;

    // Testing testing

    [Header("Collision Check")]
    [SerializeField] private float groundCheckRadius;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask whatIsGround;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        CollisionChecks();

        xInput = Input.GetAxisRaw("Horizontal");
        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void CollisionChecks()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private void Movement()
    {
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
