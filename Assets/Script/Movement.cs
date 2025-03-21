using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveInput;
    private bool isRight = true;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jump = 10f;
    [SerializeField] private LayerMask groundLayer;
    private Rigidbody2D rb;
    [SerializeField]private Transform ground;
    private bool isGround;
    private Animator an;
    private void Awake()
    {
        an = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
         moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        move();
        jumpMove();
        updateAnimator();
        attack();
    }

    private void move()
    {
        
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        flip();
    }

    private void flip()
    {
        if(isRight && moveInput < 0f || !isRight && moveInput >0f)
        {
            isRight = !isRight;
            Vector3 lcScale = transform.localScale;
            lcScale.x *= -1;
            transform.localScale = lcScale;
        }
    }

    private void jumpMove()
    {
        int count = 0;
        if (Input.GetButtonDown("Jump") && isGround)
        {
            rb.velocity = new Vector2 (rb.velocity.x,jump);
            count++;
        }
        isGround = Physics2D.OverlapCircle(ground.position, 0.2f, groundLayer);
        

            if (Input.GetButtonDown("Jump") && rb.velocity.y > 0f && count < 2)
            {
                rb.velocity = new Vector2(rb.velocity.x, jump * 0.5f);
            }
        count = 0;
    }
    private void updateAnimator()
    {
        bool isWalk = math.abs(rb.velocity.x) > 0f;
        bool isJump = !isGround;
        an.SetBool("isWalk", isWalk);
        an.SetBool("isJump", isJump);
    }

    private void attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            an.SetTrigger("attack");
        }
    }
    
}
