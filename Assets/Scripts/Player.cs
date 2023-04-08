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

    Vector3 direction = Vector3.zero;
    Vector3 position = Vector3.zero;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        rb.velocity += new Vector3(0, 0.5f);
    }
}
