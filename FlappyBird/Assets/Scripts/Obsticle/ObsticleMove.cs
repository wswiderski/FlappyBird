using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleMove : MonoBehaviour {

    private bool canMove;
	
	void Update () {
        transform.position = new Vector2(
            transform.position.x - EnvMove.environmentSpeed * Time.deltaTime,
            transform.position.y);
    }
}
