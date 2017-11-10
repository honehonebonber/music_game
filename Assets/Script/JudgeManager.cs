using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeManager : MonoBehaviour {
	public static JudgeManager instance;
	public float musicStart = 4.0f;
	private float timer;
	public float Timer{ get {return timer; } }
	public string[,] csv;
	public TextAsset csvFile;


	void Start(){
		instance = this;
		csv = CSVReader.SplitCsvGrid (csvFile.text);
		int bpm = int.Parse (csv [0, 0]);
		float interval = 1 / (bpm / 60.0f) / 2;
	}
	public void Judge(JudgeButton judgeButton){
		/*if (csv [judgeButton.Position, ] == "1") {
			
		}*/
	}
}
