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
        gameStage = GameStages.DEMO;
    }

    private void DemoStage()
    {
        player.DisableGravity();
        gameStage = GameStages.DEMO;
    }

    private void PLayStage()
    {
        player.EnableGravity();
        player.EnableMove();
        player.MoveBirdUp();
        gameStage = GameStages.PLAY;
    }

    public void GameOverStage()
    {
        gameStage = GameStages.GAME_OVER;
        player.DisableMove();
    }

    private void ResetGame()
    {
        points = 0;
        gameStage = GameStages.DEMO;
        DemoStage();
    }

    public void AddPoint()
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
