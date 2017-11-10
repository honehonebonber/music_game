 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public static TimeManager instance;

	[SerializeField]
	private Text startLabel;
	[SerializeField]
	private Text timeText;
	public float musicStart = 4.0f;
	public float nowTime;
	// 処理の時は (Time.time - musicStart);
	// Use this for initialization
	void Start () {
		instance = this;
		StartCoroutine ("StartMusic");  
	}
	
	// Update is called once per frame
	void Update () {
		nowTime = Time.time - musicStart;
		timeText.text = (nowTime).ToString();
	}

	private IEnumerator StartMusic() {
		yield return new WaitForSeconds (1.0f);

		for (int i = 3; i > 0; i--) {
			startLabel.text = i.ToString();
			yield return new WaitForSeconds (1.0f);
		}
//		Judge.instance.JudgeStart ();
		startLabel.text = "Start!";
		yield return new WaitForSeconds (0.5f);
		Destroy (startLabel);
	}
}
