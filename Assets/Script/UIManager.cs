using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager 
: SingletonMonoBehaviour<UIManager> {

	[SerializeField] private Text 
		startCountLabel,
		scoreLabel,
		compoLabel,
		highScoreLabel,
		timerLabel;

	private void Update () {
		if (TimeManager.IsPlaying) 
			timerLabel.text = TimeManager.ElapsedTime.ToString("f2") + "秒";
	}

	public void SetScore (int score) {
		scoreLabel.text = "Score : " + score;
	}

	public void SetCombo (int combo) {
		compoLabel.text = "Combo : " + combo;
	}

}
