using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class JudgeManager : MonoBehaviour {
	public static JudgeManager instance;
	[SerializeField] private JudgeButton[] judgeBottons; 
	public JudgeButton GetJudgeBotton(int position) {
		var judgeBotoon = judgeBottons.ToList ().Find (j => j.Position == position);
		return judgeBotoon;
	} 

	public float musicStart = 4.0f;
	private float timer = 0;
	public float Timer{ get {return timer; } }
	public string[,] csv;
	public TextAsset csvFile;
	public static int score = 0;
	public static int combo = 0;
	public static int highScore;

	void Start(){
		instance = this;
		csv = CSVReader.SplitCsvGrid (csvFile.text);
		highScore = PlayerPrefs.GetInt("HighScore");
	}

	void Update(){
		if (score > highScore) {
			//ハイスコア更新
			highScore = score;
			//ハイスコアを保存
			PlayerPrefs.SetInt("HighScore", highScore);
			PlayerPrefs.Save();
		}
	}
	public void Judge (JudgeButton judgeButton){
		if (csv [judgeButton.Position, NotesSpawnManager.instance.CurrentJudgeNotes()] == "1") {
			judgeButton.JudgeEffect ();
			combo++;
			score += 100 + combo;
		}
	}
}
