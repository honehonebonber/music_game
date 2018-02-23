using System.Collections.Generic;

[System.Serializable]
public class User{
	public string name;
	public List<MusicResults> musicResults;
	public int eventID = 0;
	//0=なし,1=チュートリアル,
	public bool tutorial = true;
}