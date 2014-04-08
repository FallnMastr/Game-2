using UnityEngine;
using System.Collections;

public class player_missile : MonoBehaviour {

	int fuel = 100;
	GameObject target;
	float speed = 5;
	string shooter = "";

	bool noTarget = false;
	Vector3 blank = new Vector3(0,20,0);

    public AudioSource missile;

	// Use this for initialization
	void Start () {
		aquireTarget ();
		//boom = GetComponent<Animation> ();

        missile = (AudioSource)gameObject.AddComponent("AudioSource");
        AudioClip missileClip;
        missileClip = (AudioClip)Resources.Load("sound_fx/missile_fire1");
        missile.clip = missileClip;
        missile.volume = 0.5f;
        missile.Play();
	}
	
	// Update is called once per frame
	void Update () {


		fuel--;
		if (fuel <= 0) {
			Instantiate(Resources.Load("Explosion_0"), gameObject.transform.position, gameObject.transform.rotation);
			Destroy(gameObject);
		}
		if (target == null) {
			aquireTarget();
		}
		if (noTarget == false && target != null) {
			transform.position = Vector3.MoveTowards (transform.position, target.transform.position, Time.deltaTime * speed);
		} else {
			transform.position = Vector3.MoveTowards (transform.position, blank, Time.deltaTime * speed);
		}
	}

	void aquireTarget(){
		if (GameObject.FindWithTag ("Relic") != null) {
			target = GameObject.FindWithTag ("Relic");
		}
		
		if (target == null || target.transform.position.x <= -9) {
			target = GameObject.FindWithTag("Boss");
		}
		
		if (target == null || target.transform.position.x <= -9) {
			GameObject [] array = GameObject.FindGameObjectsWithTag ("Enemy");
			if(array.Length > 0){
				int index = Random.Range(0,array.Length);
				target = array[index];
			}
		}

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
