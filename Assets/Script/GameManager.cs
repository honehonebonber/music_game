using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
: SingletonMonoBehaviour<GameManager> {

	const float startTime = 5.0f;

	[SerializeField] public int highScore;
	const string HighScoreSaveKey = "HighScoreSaveKey";
	
	private IEnumerator Start () {
		highScore = PlayerPrefs.GetInt(HighScoreSaveKey);
		yield return new WaitForSeconds (startTime);
		SoundManager.instance.Play(ResourceManager.instance.testMusic);
		TimeManager.MusicStart();
	}

	public void SetScore (int score) {
		if (score > highScore) {
			PlayerPrefs.SetInt(HighScoreSaveKey, highScore);
		}
	}

}
