using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicSelect : MonoBehaviour {

	[SerializeField] MusicSelectPopup musicSelectPopup;
	[SerializeField] GameObject canvas;
	private bool startOrBack;

	[SerializeField] private List<MusicData> musics;

	[SerializeField] private Button
		button1,
		button2,
		button3,
		button4,
		button5,
		button6;

	// Use this for initialization
	void Start () {
		startOrBack = false;
		button1.onClick.AddListener (() => {
			musicSelectPopup.Open(musics[0]);
		});
		button2.onClick.AddListener (() => {
			musicSelectPopup.Open(musics[1]);
		});
		button3.onClick.AddListener (() => {
			musicSelectPopup.Open(musics[2]);
		});
		button4.onClick.AddListener (() => {
			musicSelectPopup.Open(musics[3]);
		});
		button5.onClick.AddListener (() => {
			musicSelectPopup.Open(musics[4]);
		});
		button6.onClick.AddListener (() => {
			musicSelectPopup.Open(musics[5]);
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameStart(){
		SceneManager.LoadScene ("Main");
	}

}
