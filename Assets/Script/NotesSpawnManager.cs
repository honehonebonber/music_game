using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSpawnManager : MonoBehaviour {

	public GameObject notesPrefab;
	public GameObject longNotesPrefab;
	public GameObject releaseNotesPrefab;
	public int notesPosition; 
	public string[,] csv;
	public TextAsset csvFile;
	// Use this for initialization
	void Start () {
		StartCoroutine("Spawn");
	}
	
	// Update is called once per frame
	void Update () {
	}


	IEnumerator Spawn () {
		yield return new WaitForSeconds (1.0f);
		yield return new WaitForSeconds (JudgeManager.instance.musicStart);
		print (gameObject.name);
		csv = CSVReader.SplitCsvGrid (csvFile.text);

		int stage = 0;
		int bpm = int.Parse (csv [0, 0]);
		float interval = 1 / (bpm / 60.0f) / 2;
		//print (interval);
		while (true) {
			yield return new WaitForSeconds (interval);
			stage += 1;
			if (csv [notesPosition, stage] == "1") {
				Instantiate (notesPrefab, this.transform.position, Quaternion.identity);
			}
		}

	}
}
