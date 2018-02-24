using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUpdater : MonoBehaviour {

    public Text points;
    
    public void UpdatePointsText()
    {
        points.text = GameManager.Points.ToString();
    }
}
