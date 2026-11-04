using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { MainMenu,GamePlay, Pause}
public class GameLogic : MonoBehaviour 
{
    public Gradient bgColor;
    public static GameState gameState = GameState.GamePlay;

    private void Awake()
    {
        The.gameLogic = this;
    }
    // Use this for initialization
    void Start () {
		
	}
	public void GetPoints()
    {
        Var.score += Var.scorePerClick;
        Camera.main.backgroundColor = bgColor.Evaluate(Random.value);
        The.gameUI.UpdateScore();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
