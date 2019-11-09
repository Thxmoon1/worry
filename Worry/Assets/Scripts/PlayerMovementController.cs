using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public CharacterController2D controller;
    public float speed = 20f;
    private float horizontalMove = 0f;
    void Start()
    {
        
    }

    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(horizontalMove);
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
