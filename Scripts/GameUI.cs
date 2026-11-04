using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour {
    public TMP_Text scoreText;
    public Slider levelSlider;
    public TMP_Text sliderText;
    public GameObject gameUI;
    public GameObject pauseUI;
    // Use this for initialization
    private void Awake()
    {
        The.gameUI = this;
    }
    void Start () {
        UpdateScore();
        Refresh();
	}
	public void UpdateScore()
    {
        scoreText.text = Var.score.ToString();
        levelSlider.value = (float)(Var.score % 10)/10f;
        sliderText.text = "Level " + (1+Var.score / 10);
    }
    public void PauseGame()
    {
        GameLogic.gameState = GameState.Pause;
        Refresh();
    }
    public void UnpauseGame()
    {
        GameLogic.gameState = GameState.GamePlay;
        Refresh();
    }

    public void Refresh()
    {
        if(GameLogic.gameState == GameState.GamePlay)
        {
            pauseUI.SetActive(false);
            gameUI.SetActive(true);
        }
        else
        {
            pauseUI.SetActive(true);
            gameUI.SetActive(false);
        }
    }
}
