using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
: SingletonMonoBehaviour<GameManager> {

	const float startTime = 3.0f;

	[SerializeField] public int highScore;
	const string HighScoreSaveKey = "HighScoreSaveKey";
	
	private IEnumerator Start () {
		highScore = PlayerPrefs.GetInt(HighScoreSaveKey);
		yield return new WaitForSeconds (startTime);
		NotesManager.instance.SpawnStart();
		yield return new WaitForSeconds (NotesController.ToMarkerDuration);
		SoundManager.instance.Play(ResourceManager.instance.testMusic);
		TimeManager.MusicStart();
	}

	public void SetScore (int score) {
		if (score > highScore) {
			PlayerPrefs.SetInt(HighScoreSaveKey, highScore);
		}
	}

}
