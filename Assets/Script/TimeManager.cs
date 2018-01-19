using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : SingletonMonoBehaviour<TimeManager> {

	private static float startTime, elapsedTime;
	public static float ElapsedTime {
		get { return Time.time - TimeManager.startTime; }
	}

	private static bool isPlaying = false;
	public static bool IsPlaying { get { return isPlaying; } }

	public static void MusicStart () {
		isPlaying = true;
		elapsedTime = 0;
		startTime = Time.time;
	}

	public static void MusicStop () {
		isPlaying = false;
		elapsedTime = 0;
	}
}
