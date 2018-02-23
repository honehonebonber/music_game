using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager 
: SingletonMonoBehaviour<GameManager> {

	const float startTime = 5.0f;
	private int highScore = 0;
	public User user;
	const string _SaveKey = "UserData";
	public static GameManager instance;
	
	private IEnumerator Start () {
		instance = this;
		string json = PlayerPrefs.GetString(_SaveKey);
		user = JsonUtility.FromJson<User>(json);
		/*yield return new WaitForSeconds (startTime);
		SoundManager.instance.Play(ResourceManager.instance.testMusic);
		TimeManager.MusicStart();
		SceneManager.LoadScene("Result");*/
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
