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

	
	private IEnumerator Start () {
	/*	string json = PlayerPrefs.GetString (_SaveKey);
		user = JsonUtility.FromJson<User> (json);
		highScore = PlayerPrefs.GetInt (HighScoreSaveKey);*/

		yield return new WaitForSeconds (startTime);
		NotesManager.instance.SpawnStart ();
		yield return new WaitForSeconds (NotesController.ToMarkerDuration);
		SoundManager.instance.Play (ResourceManager.instance.testMusic);
		TimeManager.MusicStart ();
		yield return new WaitForSeconds (10.0f);
		ToResult ();
	}

	public void ToResult() {
		SceneManager.LoadScene("Result");
	}





	/*public void Save (User user) {
		string json = JsonUtility.ToJson( user );
		PlayerPrefs.SetString(_SaveKey, json);
	}*/
}
