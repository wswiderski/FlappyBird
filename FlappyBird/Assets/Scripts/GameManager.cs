using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public enum GameStages
    {
        DEMO, PLAY, GAME_OVER
    }

    private static int points = 0;
    private static GameStages gameStage;

    private void Awake()
    {
        points = 0;
        gameStage = GameStages.DEMO;
    }

    private void OnDemoStage()
    {
        gameStage = GameStages.DEMO;
    }

    private void OnPlayStage()
    {
        gameStage = GameStages.PLAY;
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
