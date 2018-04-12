using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUtils : MonoBehaviour {
	
	private void Start()
	{
		Pause();
	}

	public void Replay()
	{
		SceneManager.LoadScene(0);
	}

	// ReSharper disable once MemberCanBePrivate.Global
	// ReSharper disable once MemberCanBeMadeStatic.Global
	public void Pause()
	{
		Time.timeScale = 0f;
	}

	// ReSharper disable once MemberCanBePrivate.Global
	// ReSharper disable once MemberCanBeMadeStatic.Global
	public void Play()
	{
		Time.timeScale = 1f;
	}
	
	public void PlayPause()
	{
		if (Time.timeScale > 0.5f)
		{
			Pause();
		}
		else
		{
			Play();
		}
	}
}
