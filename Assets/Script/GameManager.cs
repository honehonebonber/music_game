using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
	: SingletonMonoBehaviour<GameManager> {

	public User user = new User();
	const string _SaveKey = "UserData";
	public int highScore;
	const string HighScoreSaveKey = "HighScoreSaveKey";

	void Start () {
		DontDestroyOnLoad (this.gameObject);
		string json = PlayerPrefs.GetString (_SaveKey);
		user = JsonUtility.FromJson<User> (json);
		if (user == null) user = new User ();
		highScore = PlayerPrefs.GetInt (HighScoreSaveKey);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Save (User user) {
		string json = JsonUtility.ToJson( user );
		PlayerPrefs.SetString(_SaveKey, json);
	}
	public void SetScore (int score) {
		if (score > GameManager.instance.highScore) {
			PlayerPrefs.SetInt (_SaveKey, GameManager.instance.highScore);
		}
	}
}
