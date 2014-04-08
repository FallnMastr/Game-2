using UnityEngine;
using System.Collections;
using System;

public class towards02 : MonoBehaviour {
	
	int count = 0;

	// Use this for initialization
	void Start () {
		float xe = transform.position.x;
		float ye = transform.position.y;
		float ze = transform.position.z;

		float xp = 0;
		float yp = 0;
		float zp = 0;


		if(GameObject.Find("player2(Clone)") != null){
			xp = GameObject.Find("player2(Clone)").transform.position.x;
			yp = GameObject.Find("player2(Clone)").transform.position.y;
			zp = GameObject.Find("player2(Clone)").transform.position.z;
		
			float t = Convert.ToSingle(Math.Atan((xe-xp)/(ye-yp))*(180/Math.PI));
			
			transform.Rotate(new Vector3(0,0,-t));

			if (yp < ye) {
				transform.Rotate(new Vector3(0,0,180));
			}
		} else {
			suicide();
		}
	}

	// Update is called once per frame
	void Update () {
		if(GameObject.Find("player2(Clone)") != null){
			transform.Translate(Vector3.up * Time.deltaTime * 5);
		}

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
