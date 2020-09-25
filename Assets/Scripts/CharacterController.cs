using System.Collections;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;
    private bool isGrounded;

    public float jumpForce;
    public bool isJumping;
    //public float jumpTime;
    //private float jumpTimeCounter;

    private bool facingRight;

    void Start()
    {
        facingRight = true;
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        MovePlayer();
        PlayerJump();
        Flip();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-(moveSpeed * Time.deltaTime), rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2((moveSpeed * Time.deltaTime), rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    void Flip()
    {
        if (Input.GetKey(KeyCode.RightArrow) && !facingRight || Input.GetKey(KeyCode.LeftArrow) && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    void PlayerJump()
    {
        if (isGrounded == true && Input.GetKey(KeyCode.UpArrow))
        {
            isJumping = true;
            //jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        /*if (Input.GetKey(KeyCode.UpArrow) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }*/

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            isJumping = false;
        }
    }



    
}
