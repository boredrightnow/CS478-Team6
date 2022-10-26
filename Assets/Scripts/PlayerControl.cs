using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed =1f;

    public float collisionOffset = 0.05f;

    public ContactFilter2D movementFilter;

    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    private Rigidbody2D rb;

    //private bool isMoving;

    private Vector2 input;

    private Animator animator;

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isMoving = false;
        }
    }*/
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void FixedUpdate()
    {
       
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        
        bool success = MovePlayer(input);

        if (input.x == 0 && input.y == 0)
        {

            animator.SetBool("IsMoving", false);
        }
    }

    public bool MovePlayer(Vector2 direction)
    {
        int count = rb.Cast(
            direction,
            movementFilter,
            castCollisions,
            moveSpeed * Time.fixedDeltaTime + collisionOffset);
        if (count ==0)
        {
            Vector2 moveVector = direction * moveSpeed * Time.fixedDeltaTime;

            rb.MovePosition(rb.position + moveVector);
            animator.SetBool("IsMoving", true);
            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);

            return true;
        }
        else
        {
            foreach(RaycastHit2D hit in castCollisions)
            {
                print(hit.ToString());
            }
            animator.SetBool("IsMoving", false);
            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);
            return false;
        }
    }


   /* public void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            //disables diagonal movements
            if (input.x != 0) input.y = 0;
            
            

            if(input != Vector2.zero)
            {
                animator.SetFloat("moveX",input.x);
                animator.SetFloat("moveY",input.y);
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                StartCoroutine(Move(targetPos));
            }

        }
        animator.SetBool("IsMoving", isMoving);
    }
    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;

        while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;
    }*/
}
