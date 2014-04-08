using UnityEngine;
using System.Collections;

public class fireBeam_script : MonoBehaviour {

	int life = 50;

    public AudioSource beam;

    void Start() {
        beam = (AudioSource)gameObject.AddComponent("AudioSource");
        AudioClip beamClip;
        beamClip = (AudioClip)Resources.Load("sound_fx/fire_beam_short");
        beam.clip = beamClip;
        beam.Play();
    }
	
	// Update is called once per frame
	void Update () {

        if (Time.timeScale != 0) {
            life--;
        }

		if(life <= 0){
			DestroyObject(gameObject);
		}
	}
}
