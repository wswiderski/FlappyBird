using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObsticle : MonoBehaviour {

    public GameObject lowerColumn;
    public GameObject upperColumn;
    public GameObject goal;

    public Vector2 verticalPositionBorder = new Vector2(-1.5f, 3f);
    public Vector2 verticalDistance = new Vector2(1.5f, 2.2f);

	void Start () {
        SetPosition();
        SetVerticalDistanceAndGoalSize();
	}
	
    private void SetPosition()
    {
        transform.position = new Vector2(
            transform.position.x,
            Random.Range(verticalPositionBorder.x, verticalPositionBorder.y));
    }

    private void SetVerticalDistanceAndGoalSize()
    {
        float distanceBeetwenObsticles = Random.Range(verticalDistance.x, verticalDistance.y);
        float distance = distanceBeetwenObsticles / 2f;

        SetOffsetPositionY(lowerColumn, distance);
        SetOffsetPositionY(upperColumn, -distance);
        SetGoalSize(distanceBeetwenObsticles);
    }

    private void SetOffsetPositionY(GameObject obsticle, float distance)
    {
        obsticle.transform.position = new Vector2(
            obsticle.transform.position.x,
            obsticle.transform.position.y - distance);
    }

    private void SetGoalSize(float distance)
    {
        BoxCollider2D collider = goal.GetComponent<BoxCollider2D>();
        collider.size = new Vector2(collider.size.x, distance); 
    }
}
