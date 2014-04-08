using UnityEngine;
using System.Collections;

public class explosion_small : MonoBehaviour {
	public AudioSource impact;
    int count;

	// Use this for initialization
	void Start () {
        count = 0;

        impact = (AudioSource)gameObject.AddComponent("AudioSource");
        AudioClip impactClip;
        impactClip = (AudioClip)Resources.Load("sound_fx/ship_explosion2");
        impact.clip = impactClip;
        impact.Play();
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.timeScale != 0) {
            count++;
        }

        if (count == 15) {
			suicide();				
		}
	}

    void suicide(){
		UnityEngine.Object.Destroy (gameObject);
	}
}
