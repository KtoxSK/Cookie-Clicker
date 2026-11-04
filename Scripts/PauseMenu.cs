using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour 
{
	public GameObject pausePanel;
    public GameObject mainMenuPanel;
	private bool isPaused = false;

	// Use this for initialization
	void Start()
    {
    pausePanel.SetActive(false);

    mainMenuPanel.SetActive(true);

    Time.timeScale = 0f;
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (isPaused)
				ContinueGame();
			else
				Pause();
		}
	}
	
	public void Pause()
	{
		pausePanel.SetActive(true);
		Time.timeScale = 0f;
		isPaused = true;
	}

	public void ContinueGame()
	{
		pausePanel.SetActive(false);
		Time.timeScale = 1f;
		isPaused = false;
	}

    public void OpenMainMenu()
    {
    pausePanel.SetActive(false);
    mainMenuPanel.SetActive(true);

    Time.timeScale = 0f;
    }

    public void PlayGame()
    {
    mainMenuPanel.SetActive(false);

    Time.timeScale = 1f;

    isPaused = false;
    }
}
