using UnityEngine;
using System.Collections;

public class skip_intro_script : MonoBehaviour {

    public AudioSource intro;

	// Use this for initialization
	void Start () {
        intro = (AudioSource)gameObject.AddComponent("AudioSource");
        AudioClip introClip;
        introClip = (AudioClip)Resources.Load("tunes/A-Ha_-_Take_On_Me_Instrumental_Mix_");
        intro.clip = introClip;
        intro.volume = 0.05f;
        intro.Play();
	}
	
	// Update is called once per frame
	void Update () {
		waitInput ();
	}

	IEnumerator waitInput(){
		bool start = Input.anyKey;
		
		yield return new WaitForSeconds (1);
		
		if(start){
			Application.LoadLevel(Application.loadedLevel+1);
		}
	}
}
