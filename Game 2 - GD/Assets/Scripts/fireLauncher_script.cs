using UnityEngine;
using System.Collections;

public class fireLauncher_script : MonoBehaviour {

	int timer = 100;
	GameObject beam;

	bool fall_away = false;
	bool need_fire = true;

	Vector3 diePoint;

	// Use this for initialization
	void Start () {

		float X = gameObject.transform.position.x;
		float Y = gameObject.transform.position.y - 10;
		float Z = gameObject.transform.position.z;

		diePoint = new Vector3(X, Y, Z);
	}
	
	// Update is called once per frame
	void Update () {
		if (!fall_away) {

            if (Time.timeScale != 0) {
                timer--;
            }
			
            if (timer <= 20 && need_fire) {

				Vector3 loc = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 5, gameObject.transform.position.z);
				beam = (GameObject)Instantiate (Resources.Load ("player_shot_beam"), loc, gameObject.transform.rotation);
				need_fire = false;
			}
			if(need_fire == false && beam == null){
				fall_away = true;
			}
		} else {
			gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, diePoint, Time.deltaTime * 2f);
			if(gameObject.transform.position.y <= -8){
				Destroy(gameObject);
			}
		}
	}


}
