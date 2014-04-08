using UnityEngine;
using System.Collections;

public class start_script : MonoBehaviour {

    public AudioSource start;

    // Use this for initialization
	void Start () {
        start = (AudioSource)gameObject.AddComponent("AudioSource");
        AudioClip myAudioClip;
        myAudioClip = (AudioClip)Resources.Load("tunes/Razihel - Renzokuken");
        start.clip = myAudioClip;
        start.volume = 0.5f;
        start.Play();
        start.loop = true;
    }
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.End)){
			Application.LoadLevel(12);
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
            Debug.Log("quit");
		}
	}
}
