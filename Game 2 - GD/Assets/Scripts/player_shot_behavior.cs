using UnityEngine;
using System.Collections;

public class player_shot_behavior : MonoBehaviour {

	int count = 0;

	int speed = 10; //how fast the bullet moves

	public string shooter = "player"; //who fire the bullet
	public string element = "element"; //what type the bullet is



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime * speed);

		if (Time.timeScale != 0) {
		    count++;
        }

		if (count > 80) {
			suicide ();
		}
	}

	void suicide(){
		Object.Destroy (gameObject);
	}
	

	public void setShooter(string s){
		shooter = s;
	}

	public string getShooter(){
		return shooter;
	}

	public void setElement(string e){
		element = e;
	}

	public string getElement(){
		return element;
	}
}
