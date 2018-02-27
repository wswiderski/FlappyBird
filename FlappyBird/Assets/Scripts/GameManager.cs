using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private const string INFO_TXT = "Tap LMB to start game";
    private const string GAME_OVER_INFO_TEXT = "Your score: ";

    public PlayerMove player;
    public PointUpdater pointUpdater;
    public Animator animator;

    public Text infoText;
    public Text retryBtn; 

    private static int points = 0;
    private static GameStages gameStage;

    private void Start()
    {
        DemoStage();
    }

    private void Update()
    {
        if(gameStage == GameStages.DEMO && Input.GetKeyDown(KeyCode.Mouse0))
        {
            PlayStage();
        }
    }

    public void DemoStage()
    {
        ResetPoint();
        player.ResetPlayer();
        player.DisableGravity();

        infoText.text = INFO_TXT;
        infoText.enabled = true;
        retryBtn.enabled = false;

        animator.SetBool("isBirdBroken", false);

        ObsticleManager.DeleteAllObsticles();

        gameStage = GameStages.DEMO;
    }

    private void PlayStage()
    {

        player.EnableGravity();
        player.EnableMove();
        player.MoveBirdUp();

        infoText.enabled = false;

        gameStage = GameStages.PLAY;
    }

    public void GameOverStage()
    {
        player.DisableMove();

        infoText.text = GAME_OVER_INFO_TEXT + points.ToString();
        infoText.enabled = true;
        retryBtn.enabled = true;

        animator.SetBool("isBirdBroken", true);

        gameStage = GameStages.GAME_OVER;
    }

    public void AddPoint()
    {
        points++;
        pointUpdater.UpdatePointsText();
    }

    private void ResetPoint()
    {
        points = 0;
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
