using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float movespeed;
    [SerializeField]
    private Vector3 position;
    private float distance;
    private bool right = true;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(right == true){
            position.x += 10;
        }
        else{
            position.x -= 10;
        }
        position = transform.position;
    }
}
