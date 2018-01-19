using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesManager 
: SingletonMonoBehaviour<NotesManager> {

	public GameObject notesPrefab;
	public GameObject longNotesPrefab;
	public GameObject releaseNotesPrefab;
	public int notesPosition; 
	public string[,] csv;
	public TextAsset csvFile;

	public int stage = 0;
	public float interval;
	private float NotesMoveTime = 1.5f;

	IEnumerator Spawn () {
		yield return new WaitForSeconds (1.0f);
		yield return new WaitForSeconds (JudgeManager.instance.musicStart - NotesMoveTime);
		//yield return new WaitForSeconds (TimeManager.instance.musicStart);
		csv = CSVReader.SplitCsvGrid (csvFile.text);

		stage = 0;
		int bpm = int.Parse (csv [0, 0]);
		interval = 1 / (bpm / 60.0f) / 2;
		print (interval);
		//1.5秒前に生成
		while (true) {
			yield return new WaitForSeconds (interval);
			stage += 1;
			if (csv [notesPosition, stage] == "1") {
				Instantiate (notesPrefab, this.transform.position, Quaternion.identity);
			}
		}

	}

	public int CurrentJudgeNotes(){
		return stage - Mathf.RoundToInt(NotesMoveTime / interval) ;
	}
	// public float DifferenceOfCurrentTime(){
	//	 return TimeManager.instance.nowTime - (CurrentJudgeNotes() * interval);
	// }
}
