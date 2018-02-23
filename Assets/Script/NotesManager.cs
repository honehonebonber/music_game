using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesManager 
: SingletonMonoBehaviour<NotesManager> {

	[SerializeField] private Transform[] spawnPoints;

	public GameObject notesPrefab;
	public GameObject longNotesPrefab;
	public GameObject releaseNotesPrefab;
	public int notesPosition; 
	public string[,] csv;
	public TextAsset csvFile;

	private bool isStart = false;
	private int stage = 0;
	private float interval;

	public float NextSpawnTime {
		get {
			return (stage + 1) * interval;
		}
	}

	public void SpawnStart () {
		csv = CSVReader.SplitCsvGrid (csvFile.text);
		stage = 0;
		int bpm = int.Parse (csv [0, 0]);
		interval = 1 / (bpm / 60.0f) / 2;
		print (interval);
		isStart = true;
	}

	private void Update () {
		if (!isStart) return;
		if (TimeManager.ElapsedTime > NextSpawnTime) {
			stage += 1;
			for (int i=0; i<6; i++) {
				if (csv[i, stage] == "1") {
					SpawnNotes(i);
				}
			}
		}
	}

	private void SpawnNotes (int line) {
		var obj = Instantiate (notesPrefab);
		obj.transform.position = spawnPoints[line].position;
		var notes = obj.GetComponent<NotesController>();
		notes.SetUp(line, stage, spawnPoints[line]);
	}
}
