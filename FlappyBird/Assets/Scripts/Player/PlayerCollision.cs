using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    private const string GOAL = "Goal";
    private List<string> OBSTICLE_TAGS = new List<string>{ "Obsticle", "Environment" };

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (OBSTICLE_TAGS.Contains(collision.collider.tag)){
            gameManager.GameOverStage();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(GOAL))
        {
            gameManager.AddPoint();
        }
    }
}
