using System.Collections.Generic;
[System.Serializable]
public class MusicData {
	public int ID;
	public string MusicName;
	public int BPM;
	public static List<float> judgeTiming = new List<float>(){2.7f};
	public string JacketPath () {
		return "Jacket/" + ID;
	}
}