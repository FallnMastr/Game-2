using UnityEngine;
using System.Collections;

public class relic_launch_script : MonoBehaviour {
	public AudioSource au_relic;
	bool bool_audio_relic = true;

	int engage = 100; //what time the relic appears
	int count = 0;

	bool loop = true;
	bool done = false;
	
	GameObject relic;
	Vector3 vector;

	// Use this for initialization
	void Start () {
		engage = Random.Range (2000, 8000);

		vector = new Vector3 (Random.Range (-3, 5), Random.Range (-3, 5), 0);
		Vector3 start = new Vector3 (-10, 0, 0);
		relic = (GameObject)Instantiate (Resources.Load ("Relic"), start, gameObject.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		if (!done) {
			if (count >= engage) { 
				if(bool_audio_relic){
                    au_relic = (AudioSource)gameObject.AddComponent ("AudioSource");
				    AudioClip myAudioClip;
				    myAudioClip = (AudioClip)Resources.Load ("sound_fx/relic sound");
				    au_relic.clip = myAudioClip;
					au_relic.volume = 0.01f;
					au_relic.Play();
					bool_audio_relic=false;}
				loop = false;

				if(relic != null){
					relic.transform.position = Vector3.MoveTowards (relic.transform.position, vector, Time.deltaTime * 3f);
					if (relic.transform.position == vector) {
						relic.SendMessage ("move");
						done = true;
					}
				}
			} else {
				if (Time.timeScale != 0) {
                    count++;
                }
			}
		}
	}
}