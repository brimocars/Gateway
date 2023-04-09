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

    //Vector3 gravity = new Vector3(0, -1, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        rb.velocity += new Vector2(0, 0.5f);
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            rb.velocity = Vector3.zero;
        }
    }
}
