using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager 
: SingletonMonoBehaviour<MainSceneManager> {

	const float startTime = 3.0f;
	public User user;
	const string _SaveKey = "UserData";
	public static MainSceneManager instance;
	[SerializeField] private int highScore;
	const string HighScoreSaveKey = "HighScoreSaveKey";
	
	private IEnumerator Start () {
		instance = this;
		string json = PlayerPrefs.GetString (_SaveKey);
		user = JsonUtility.FromJson<User> (json);
		highScore = PlayerPrefs.GetInt (HighScoreSaveKey);

		yield return new WaitForSeconds (startTime);
		NotesManager.instance.SpawnStart ();
		yield return new WaitForSeconds (NotesController.ToMarkerDuration);
		SoundManager.instance.Play (ResourceManager.instance.testMusic);
		TimeManager.MusicStart ();
	}

	public void ToResult() {
		SceneManager.LoadScene("Result");
	}

	public void SetScore (int score) {
		if (score > highScore) {
			PlayerPrefs.SetInt(_SaveKey, highScore);
		}
	}

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}

	public void Save (User user) {
		string json = JsonUtility.ToJson( user );
		PlayerPrefs.SetString(_SaveKey, json);
	}
}
