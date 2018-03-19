using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameseting : MonoBehaviour {
	public Slider slider;
	public Text valueCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		valueCount.text = slider.value.ToString ();
		AudioListener.volume = slider.value;
	}

}
