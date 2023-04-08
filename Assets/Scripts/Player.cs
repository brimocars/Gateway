using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnMove(InputAction.CallbackContext context)
    {
        Vector3 direction = context.ReadValue<Vector2>();

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
