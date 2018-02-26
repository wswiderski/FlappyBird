﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float force = 5f;
    public float lengthOfDemoFly = 1f;
    public float demoFlyTimeFactor = 0.7f;

    private Rigidbody2D rb;
    private bool canMove = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(GameManager.GameStage == GameStages.DEMO)
        {
            DemoFly();
        }
        else if (GameManager.GameStage == GameStages.PLAY && canMove)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                MoveBirdUp();
            }
        }
    }

    public void MoveBirdUp()
    {
        rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }

    public void DisableGravity()
    {
        rb.gravityScale = 0f;
    }

    public void EnableGravity()
    {
        rb.gravityScale = 1f;
    }

    public void DisableMove()
    {
        canMove = false;
    }

    public void EnableMove()
    {
        canMove = true;
    }

    public void ResetPlayer()
    {
        transform.position = new Vector2(0f, 0f);
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    private void DemoFly()
    {
        Vector2 newPosition = new Vector2(0f, Mathf.PingPong(Time.time * demoFlyTimeFactor, lengthOfDemoFly));
        rb.MovePosition(newPosition);
    }
}
