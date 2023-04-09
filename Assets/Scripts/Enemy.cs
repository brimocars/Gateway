using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb; 
    private float movespeed;
    [SerializeField]
    private float distance;
    private bool right = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (right == false){
            if(transform.position.x <= -6 ) {
                right = true;
                rb.velocity = new Vector3(1,0,0); 
            }
        }
        else{
            if(transform.position.x >= 6 ) {
                right = false;
                rb.velocity = new Vector3(-1,0,0); 
            }
        }
        transform.position += rb.velocity;
    }
}
