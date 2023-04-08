using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float movespeed;
    private float startPosition;
    private float distance;
    private Rigitbody2d rgb2d;

    // Start is called before the first frame update
    void Start()
    {
        rgb2d - GetComponent<Rigitbody2d>();
        startPosition = rgb2d.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        rgb2d.MovePosition(new Vector2((Mathf.Sin((2 * Mathf.PI * (Time.time*linearSpeed/distance)) - (Mathf.PI / 2)) * (distance/2) + (distance/2))+startPosition,rgb2d.position.y));
    }
}
