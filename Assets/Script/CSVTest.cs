using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVTest : MonoBehaviour {
	public string[,] csv;
	public TextAsset csvFile;

	// Use this for initialization
	IEnumerator Start () {
		csv = CSVReader.SplitCsvGrid (csvFile.text);
		Debug.Log (csv[1,3]);
		int row = 1;
		while (true) {
			yield return new WaitForSeconds (0.3f);
			string log = "";
			for (int i = 0; i < 6; i++) {
				log += " " + csv [i, row];
				if (csv [i, row] == "1") {
					print ("キター！！");

				}
			}
			Debug.Log (log);
			row += 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
