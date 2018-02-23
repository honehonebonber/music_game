using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {
	[SerializeField] private Text
		scoreText,
		comboText;
	// Use this for initialization
	void Start () {
		JudgeManager.score = Random.Range (0, 101);
		JudgeManager.combo = Random.Range (0, 101);
		scoreText.text = ("SCORE:" + JudgeManager.score);
		comboText.text = ("COMBO:" + JudgeManager.combo);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonTouch(){
		SceneManager.LoadScene ("Energy");
	}
}
