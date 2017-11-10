using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSceneUIManager : MonoBehaviour {
	public static MusicSceneUIManager instance;
	[SerializeField]
	private Text 
		startLabel, 
		timeText,
		scoreText,
	    comboText,
	    highScoreText;
	// Use this for initialization
	void Start () {
		instance = this;
		StartCoroutine ("StartMusic");  
	}
	
	// Update is called once per frame
	void Update () {
		float timer = JudgeManager.instance.Timer;
		scoreText.text = ("SCORE:" + Judge.score);
		comboText.text = ("COMBO:" + Judge.combo);
		highScoreText.text = ("HIGH SCORE:" + Judge.highScore);
	}


}
