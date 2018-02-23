using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicSelectPopup : MonoBehaviour {

	[SerializeField] private Button cancelButton, okButton;

	private void Awake () {
		cancelButton.onClick.AddListener (() => {
			gameObject.SetActive(false);
		});
		okButton.onClick.AddListener (() => {
			SceneManager.LoadScene("Main");
		});
	}

	public void Open (/*int musicID*/) {
		gameObject.SetActive (true);
	}

}
