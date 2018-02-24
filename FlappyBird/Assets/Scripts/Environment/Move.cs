using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public static float environmentSpeed = 2.5f;

    public Vector2 respawnPosition = new Vector2(27f, 0f);
    public float endXPosition = -27f;

    private Vector2 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if(transform.position.x <= endXPosition)
        {
            transform.position = respawnPosition;
        }

        MoveObject();
    }

    public void ResetToStartPosition()
    {
        transform.position = startPosition;
    }

    private void MoveObject()
    {
        transform.position = new Vector2(
            transform.position.x - environmentSpeed * Time.deltaTime,
            transform.position.y);
    }
}
