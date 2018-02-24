using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public PlayerMove player;
    public PointUpdater pointUpdater;

    private static int points = 0;
    private static GameStages gameStage;

    private void Start()
    {
        points = 0;
        gameStage = GameStages.PLAY;
    }

    private void OnDemoStage()
    {
        gameStage = GameStages.DEMO;
        player.DisableGravity();
    }

    private void OnPlayStage()
    {
        gameStage = GameStages.PLAY;
        player.EnableGravity();
    }

    private void OnGameOverStage()
    {
        gameStage = GameStages.GAME_OVER;
    }

    private void ResetGame()
    {
        points = 0;
        gameStage = GameStages.DEMO;
    }

    public static void AddPoint()
    {
        points++;
        pointUpdater.UpdatePointsText();
    }

    public static GameStages GameStage
    {
        get
        {
            return gameStage;
        }
    }

    public static int Points
    {
        get
        {
            return points;
        }
    }
}
