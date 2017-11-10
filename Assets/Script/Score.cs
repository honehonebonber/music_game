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
		scoreText.text = ("SCORE:" + Judge.score);
		comboText.text = ("COMBO:" + Judge.combo);
		highScoreText.text = ("HIGH SCORE:" + Judge.highScore);
	}
}
