using System.Collections.Generic;

[System.Serializable]
public class MusicData {
	public int 
		musicid,
		BPM,
		maxEnergy;
	public string name;
	public static List<float> judgeTiming = new List<float>(){2.7f};

	public string JacketPath () {
		return "Jacket/" + musicid;
	}
}