using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField] public float speed = 5.0f;
    public Rigidbody2D rb;
    private Animator animator;
    Vector2 MoveXY;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        MoveXY.x = Input.GetAxisRaw("Horizontal");
        MoveXY.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        MovementPlayer();
        AnimatorCharacter();
       //float moveHorizontal = Input.GetAxis("Horizontal");
       //float moveVertical = Input.GetAxis("Vertical");
       //Vector2 movement = new Vector2(moveHorizontal, moveVertical);
       //rb.velocity = movement * speed / Time.fixedDeltaTime;
       //Debug.Log(Time.fixedDeltaTime);
    }

    void MovementPlayer()
    {
        rb.MovePosition(rb.position +  MoveXY.normalized * speed * Time.fixedDeltaTime);
    }

    void AnimatorCharacter()
    {
        if(MoveXY != Vector2.zero)
        {
            animator.SetFloat("XInput", MoveXY.x);
            animator.SetFloat("YInput", MoveXY.y);
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }
       //else
       //{
       //    animator.SetBool("Moving", false);
       //}
    }

}

