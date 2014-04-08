using UnityEngine;
using System.Collections;

public class enemy_missile : MonoBehaviour {

	int fuel = 100;
	GameObject target;
	float speed = 5;
	string shooter = "";

	bool noTarget = false;
	Vector3 blank = new Vector3(0,20,0);

	// Use this for initialization
	void Start () {
		aquireTarget ();
	}
	
	// Update is called once per frame
	void Update () {

		fuel--;
		if (fuel <= 0) {
			Destroy(gameObject);
		}

		if (target == null) {
			aquireTarget();
		}
		if (noTarget == false) {
			transform.position = Vector3.MoveTowards (transform.position, target.transform.position, Time.deltaTime * speed);
		} else {
			transform.position = Vector3.MoveTowards (transform.position, blank, Time.deltaTime * speed);
		}
	}

	void aquireTarget(){
		target = GameObject.FindGameObjectWithTag ("Player");
		
		if (target == null) {
			noTarget = true;
		} else {
			noTarget = false;
		}
	}

	public void setShooter(string s){
		shooter = s;
	}
	
	public string getShooter(){
		return shooter;
	}
}