﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trigger");
    }
}
