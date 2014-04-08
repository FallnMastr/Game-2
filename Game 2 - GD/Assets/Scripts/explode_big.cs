using UnityEngine;
using System.Collections;

public class explode_big : MonoBehaviour {
    public AudioSource explosion;

	// Use this for initialization
	void Start () {
        explosion = (AudioSource)gameObject.AddComponent("AudioSource");
        AudioClip explosionClip;
        explosionClip = (AudioClip)Resources.Load("sound_fx/ship_explosion1");
        explosion.clip = explosionClip;
        explosion.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<SpriteRenderer> ().sprite.ToString ().Contains ("9")) {
			Destroy(gameObject);
		}
	}
}
