using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObsticles : MonoBehaviour {

    public float xPositionToDestroyObsticle = -8f;

	void Update () {
		if(transform.position.x <= xPositionToDestroyObsticle)
        {
            DestroyObsticle();
        }
	}

    public void DestroyObsticle()
    {
        ObsticleManager.obsticles.Remove(gameObject);
        Destroy(gameObject);
    }
}
