using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedRight = 5f;
    public float speedLeft = 2f;
    private Rigidbody2D rb;
    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput > 0)
        {
            MoveRight();
        }
        else if (moveInput < 0)
        {
            MoveLeft();
        }
        else
        {
            StopMoving();
        }
    }

    private void MoveRight()
    {
        rb.velocity = new Vector2(speedRight, rb.velocity.y);
        animator.SetBool("isWalkingRight", true);
        animator.SetBool("isWalkingLeft", false);
    }

    private void MoveLeft()
    {
        rb.velocity = new Vector2(-speedLeft, rb.velocity.y);
        animator.SetBool("isWalkingLeft", true);
        animator.SetBool("isWalkingRight", false);
    }

    private void StopMoving()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        animator.SetBool("isWalkingRight", false);
        animator.SetBool("isWalkingLeft", false);
    }
}
