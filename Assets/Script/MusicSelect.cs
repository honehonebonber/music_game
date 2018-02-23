using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicSelect : MonoBehaviour {

	[SerializeField] MusicSelectPopup musicSelectPopup;
	[SerializeField] GameObject canvas;
	private bool startOrBack;

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
			musicSelectPopup.Open();
		});
		button2.onClick.AddListener (() => {
			musicSelectPopup.Open();
		});
		button3.onClick.AddListener (() => {
			musicSelectPopup.Open();
		});
		button4.onClick.AddListener (() => {
			musicSelectPopup.Open();
		});
		button5.onClick.AddListener (() => {
			musicSelectPopup.Open();
		});
		button6.onClick.AddListener (() => {
			musicSelectPopup.Open();
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameStart(){
		SceneManager.LoadScene ("Main");
	}

}
