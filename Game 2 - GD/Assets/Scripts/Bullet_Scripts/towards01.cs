using UnityEngine;
using System.Collections;
using System;

public class towards01 : MonoBehaviour {
	
	int count = 0;

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
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime * 5);
		
		if (Time.timeScale != 0) {
		    count++;
        }
		
		if (count > 200) {
			suicide ();
		}
	}

	void suicide(){
		UnityEngine.Object.Destroy (gameObject);
	}

	void OnTriggerEnter(Collider c){
//		Debug.Log ("bullet impact");
	}
}
