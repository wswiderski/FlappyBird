using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvMove : MonoBehaviour
{

    public static float environmentSpeed = 2f;

    public Vector2 respawnPosition = new Vector2(27f, 0f);
    public float endXPosition = -27f;

    private bool canMove = true;
    private Vector2 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (canMove)
        {
            MoveObject();
            if (transform.position.x <= endXPosition)
            {
                transform.position = respawnPosition;
            }
        }
    }

    public void ResetToStartPosition()
    {
        transform.position = startPosition;
    }

    public void DisableMovement()
    {
        canMove = false;
    }

    public void EnableMovement()
    {
        canMove = true;
    }

    private void MoveObject()
    {
        transform.position = new Vector2(
            transform.position.x - environmentSpeed * Time.deltaTime,
            transform.position.y);
    }
}
