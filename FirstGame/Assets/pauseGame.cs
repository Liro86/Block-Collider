using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour {

	public AudioClip backgroundSound;
	AudioSource cSS;
	
	void Start () {
		cSS = GetComponent<AudioSource>();	
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("f")){
			if(Time.timeScale == 1){
				Time.timeScale = 0;
			cSS.mute = true;}
			else{
				Time.timeScale = 1;
				cSS.mute = false;}
		}
	}
}
