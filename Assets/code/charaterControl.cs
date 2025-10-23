using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaterControl : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    public Vector2 inputControl;
    void Start()//one
    {

    }


    void Update()//loop
    {

        inputControl.x = Input.GetAxis("Horizontal");
        inputControl.y = Input.GetAxis("Vertical");


        //if (Input.GetKey(KeyCode.W))
        //{
        //    inputControl = Vector2.up;
        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    inputControl = Vector2.down;
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    inputControl = Vector2.left;
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    inputControl = Vector2.right;
        //}
        //else
        //{
        //    inputControl = Vector2.zero;
        //}
        rb.velocity = new Vector3(inputControl.x * speed, rb.velocity.y, inputControl.y * speed) ;
    }
}
