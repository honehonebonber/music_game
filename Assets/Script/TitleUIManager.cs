using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUIManager : MonoBehaviour {

	public Button startButton;

	void Start () {
		startButton.onClick.AddListener (() => {
			LoadScene();
		});
	}

	public void LoadScene(){
		if (GameManager.instance.user.tutorial == true) {
			GameManager.instance.user.eventID = 1;
			SceneManager.LoadScene ("Event");
		} else {
			SceneManager.LoadScene ("Select");
		}
	}
}
