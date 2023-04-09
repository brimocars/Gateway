using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using System;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float speed = 10;

    [SerializeField]
    GameObject spirit;

    Vector2 direction = Vector2.zero;
    Vector2 position = Vector2.zero;

    Rigidbody2D rb;
    BoxCollider2D box;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity += direction * speed * Time.deltaTime;
        position += rb.velocity;




        rb.velocity = Vector3.zero;
        transform.position = position;


    }



    public void OnMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    public void OnShootGuy(InputAction.CallbackContext context)
    {
        //teleport summon, then do
        //spirit.Summon();
    }

    public void OnSwap(InputAction.CallbackContext context)
    {

    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            if (IsGrounded())
            {
                rb.velocity += new Vector2(0, 1f);
            }
        }
    }


    public void OnCollisionEnter(Collision collision)
    {

    }

    private bool IsGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, 1f);
        return raycast.collider.tag == "Floor";
    }
}
