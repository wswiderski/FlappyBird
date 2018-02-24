using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObsticle : MonoBehaviour {

    public GameObject lowerColumn;
    public GameObject upperColumn;

    public Vector2 verticalPositionBorder = new Vector2(-1.5f, 3f);
    public Vector2 verticalDistance = new Vector2(1.5f, 2.2f);

	void Start () {
        SetPosition();
        SetDistance();
	}
	
    private void SetPosition()
    {
        transform.position = new Vector2(
            transform.position.x,
            Random.Range(verticalPositionBorder.x, verticalPositionBorder.y));
    }

    private void SetDistance()
    {
        float distanceBeetwenObsticles = Random.Range(verticalDistance.x, verticalDistance.y);
        float distance = distanceBeetwenObsticles / 2f;

        SetOffsetPositionY(lowerColumn, distance);
        SetOffsetPositionY(upperColumn, -distance);
    }

    private void SetOffsetPositionY(GameObject obsticle, float distance)
    {
        obsticle.transform.position = new Vector2(
            obsticle.transform.position.x,
            obsticle.transform.position.y - distance);
    }
}
