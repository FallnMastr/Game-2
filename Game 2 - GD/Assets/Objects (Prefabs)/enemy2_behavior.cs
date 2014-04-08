using UnityEngine;
using System.Collections;

public class enemy2_behavior : MonoBehaviour {
	int count = 0;
	bool x = true;
	// Use this for initialization
	void Start (){
		gameObject.transform.Translate (Vector3.down);
		gameObject.transform.Rotate (0, 0, -90);
		}
	
	// Update is called once per frame
	void Update () {
		if (count == 0) {
						gameObject.transform.Translate (Vector3.right);
						GameObject go = (GameObject)Instantiate(Resources.Load("pattern2_shot"));
			go.transform.Translate (transform.position.x,
			                        transform.position.y,
			                        transform.position.z);
			go.transform.Rotate (0,0,-90);
			count++;
				}
		if (count == 10) {
						gameObject.transform.Translate (Vector3.right);
						count++;
				} 
		if (count == 20) {
			gameObject.transform.Translate (Vector3.right);

			count++;
		} 
		if (count == 30) {
			gameObject.transform.Translate (Vector3.right);

			count++;
		} 
		if (count == 40) {
			gameObject.transform.Translate (Vector3.right);

			count++;
		} 
		if (count == 50) {
			gameObject.transform.Rotate (0,0,90);//.........................................................................
			gameObject.transform.Translate (Vector3.right);

			count++;
		} 
		if (count == 60) {
			gameObject.transform.Translate (Vector3.right);
			GameObject go = (GameObject)Instantiate(Resources.Load("pattern2_shot"));
			go.transform.Translate (transform.position.x,
			                        transform.position.y,
			                        transform.position.z);
			count++;
		} 
		if (count == 70) {
			gameObject.transform.Translate (Vector3.right);

			count++;
		} 
		if (count == 90) {
			gameObject.transform.Translate (Vector3.right);
			count++;
		} 
		if (count == 100) {
			gameObject.transform.Translate (Vector3.right);
			count++;
		} 
		if (count == 110) {
			gameObject.transform.Translate (Vector3.right);
			count++;
		} 
		if (count == 120) {
			gameObject.transform.Translate (Vector3.right);
			count++;
		} 
		if (count == 130) {
			gameObject.transform.Translate (Vector3.right);
			GameObject go = (GameObject)Instantiate(Resources.Load("pattern2_shot"));
			go.transform.Translate (transform.position.x,
			                        transform.position.y,
			                        transform.position.z);
			//gameObject.transform.Rotate (0,0,90);
			count++;
		} 

		if (count == 140) {
			gameObject.transform.Translate (Vector3.right);

			count++;
		} 
		if (count == 150) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 160) {
			//gameObject.transform.Translate (Vector3.right);
			gameObject.transform.Rotate (0,0,90);//..............................................................................
			
			count++;
		} 
		if (count == 170) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 180) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 190) {
			gameObject.transform.Translate (Vector3.right);
			GameObject go = (GameObject)Instantiate(Resources.Load("pattern2_shot"));
			go.transform.Translate (transform.position.x,
			                        transform.position.y,
			                        transform.position.z);
			go.transform.Rotate (0,0,90);
			count++;
		} 
		if (count == 200) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 210) {
			//gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 220) {
			gameObject.transform.Translate (Vector3.right);
			gameObject.transform.Rotate (0,0,90);//.......................................................................................
			
			count++;
		} 
		if (count == 230) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 240) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 250) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 260) {
			gameObject.transform.Translate (Vector3.right);
			GameObject go = (GameObject)Instantiate(Resources.Load("pattern2_shot"));
			go.transform.Translate (transform.position.x,
			                        transform.position.y,
			                        transform.position.z);
			go.transform.Rotate (0,0,180);
			count++;
		} 
		if (count == 270) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 280) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 290) {
			gameObject.transform.Translate (Vector3.right);
			GameObject go = (GameObject)Instantiate(Resources.Load("pattern2_shot"));
			go.transform.Translate (transform.position.x,
			                        transform.position.y,
			                        transform.position.z);
			go.transform.Rotate (0,0,180);
			count++;
		} 
		if (count == 300) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 310) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		}
		if (count == 320) {
			gameObject.transform.Translate (Vector3.right);
			
			count++;
		} 
		if (count == 330) {
			//gameObject.transform.Translate (Vector3.right);
			gameObject.transform.Rotate (0,0,90);
			count++;

		} 
		if (count == 340) {
						if (x) {
								count = 0;
								x = !x;
						} else {
								gameObject.transform.Translate (Vector3.right);
								count--;

						}
				}

		else {
						count++;
				}

	}
	void suicide(){
		UnityEngine.Object.Destroy (gameObject);
	}
	
	
	

	}