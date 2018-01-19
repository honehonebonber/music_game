using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
: SingletonMonoBehaviour<GameManager> {

	[SerializeField] public int highScore;
	const string HighScoreSaveKey = "HighScoreSaveKey";
	
	private void Start () {
		highScore = PlayerPrefs.GetInt(HighScoreSaveKey);
	}

	public void SetScore (int score) {
		if (score > highScore) {
			PlayerPrefs.SetInt(HighScoreSaveKey, highScore);
		}
	}

}
