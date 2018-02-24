using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleManager : MonoBehaviour {

    public static List<GameObject> obsticles = new List<GameObject>();

    public GameObject obsticlePrefab;
    public Vector2 startPosition = new Vector2(8f, 0f);
    public Vector2 timeToNextObsticle = new Vector2(3f, 5f);

    private float nextObsticle = 0f;
    private float time = 0f;
	
	private void Update () {
		if(GameManager.GameStage == GameStages.PLAY)
        {
            CreateObsticles();
        }
	}

    private void CreateObsticles()
    {
        time += Time.deltaTime;
        if(time >= nextObsticle)
        {
            GameObject obsticle = Instantiate(obsticlePrefab, startPosition, Quaternion.identity);
            obsticles.Add(obsticle);
            nextObsticle += UnityEngine.Random.Range(timeToNextObsticle.x, timeToNextObsticle.y);
        }
    }
}
