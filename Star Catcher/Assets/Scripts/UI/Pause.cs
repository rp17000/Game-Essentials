﻿using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{

	public GameObject pausedPanel;
	public GameObject HUD;
	public GameObject deathPanel;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
			StaticVars.isPaused = !StaticVars.isPaused;

		if (StaticVars.isPaused) 
		{
			Time.timeScale = 0;

			if (!StaticVars.gameOver) 
			{
				pausedPanel.SetActive (true);
				HUD.SetActive (false);
			} 
			else 
			{
				deathPanel.SetActive (true);
				HUD.SetActive (false);
			}
		}
		else
		{
			Time.timeScale = 1;
			pausedPanel.SetActive (false);
			HUD.SetActive (true);
		}
	}
}
