using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;
	public Text comboText;
	public Text highScoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = ("SCORE:" + JudgeManager.score);
		comboText.text = ("COMBO:" + JudgeManager.combo);
		highScoreText.text = ("HIGH SCORE:" + JudgeManager.highScore);
	}
}
