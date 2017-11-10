using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadTest : MonoBehaviour {

	public Sprite sprite;

	public List<MusicData> musicData;

	// Use this for initialization
	void Start () {
		Image image = GetComponent<Image>();
		sprite = Resources.Load<Sprite>(musicData[0].JacketPath());
		image.sprite = sprite;
	}

	public void GetData (MusicData data) {
		
	}
}
