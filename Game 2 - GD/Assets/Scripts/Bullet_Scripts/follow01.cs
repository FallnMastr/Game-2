using UnityEngine;
using System.Collections;
using System;

public class follow01 : MonoBehaviour {

	int count = 0;
	bool change = true;
	float u;

    public AudioSource missile;

	// Use this for initialization
	void Start () {
		float xe = transform.position.x;
		float ye = transform.position.y;
		float ze = transform.position.z;
		
		float xp = GameObject.Find("player").transform.position.x;
		float yp = GameObject.Find("player").transform.position.y;
		float zp = GameObject.Find("player").transform.position.z;
		
		float t = Convert.ToSingle(Math.Atan((xe-xp)/(ye-yp))*(180/Math.PI));

		transform.Rotate(new Vector3(0,0,-t));
		
		if (yp < ye) {
			transform.Rotate(new Vector3(0,0,180));
		}

		u = t;

        missile = (AudioSource)gameObject.AddComponent("AudioSource");
        AudioClip missileClip;
        missileClip = (AudioClip)Resources.Load("sound_fx/missile_fire1");
        missile.clip = missileClip;
        missile.volume = 0.1f;
        missile.Play();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime * 5);

		if (Time.timeScale != 0) {
		    count++;
        }
		
		if (count > 500) {
			suicide ();
		}

		float xe = transform.position.x;
		float ye = transform.position.y;
		float ze = transform.position.z;
		
		float xp = GameObject.Find("player").transform.position.x;
		float yp = GameObject.Find("player").transform.position.y;
		float zp = GameObject.Find("player").transform.position.z;

		float t = Convert.ToSingle(Math.Atan((xe-xp)/(ye-yp))*(180/Math.PI));

		if (yp < ye) {
			transform.Rotate(new Vector3(0,0,(u-t)/2));
		}

		u = t;
	}

	void suicide(){
		UnityEngine.Object.Destroy(gameObject);
	}
}