using UnityEngine;
using System.Collections;
using System;

public class enemy_pattern01 : enemy_hit {

	int count = 0;
	int fire_limiter = 1;

	int angle = 40;
	bool lr = true;		// True is right, false is left.
	
	// Use this for initialization
	void Start () {
		transform.Translate (new Vector3 (0, 15, 0));

		loadSprite ();
	}
	
	// Update is called once per frame
	void Update () {
		if (angle == 45)  lr = false;
		else if (angle == -45) lr = true;

		if (gameObject.transform.position.y > 5) {
			transform.Translate(Vector3.down * Time.deltaTime * 5);
		} else {
			if (Time.timeScale != 0) {
		        count++;
            }

			if (count == 216) {
				count = 0;
			}

			if (count <= 73) {
				if(count % fire_limiter == 0){
					if (lr) angle += 5;
					else angle -= 5;

					GameObject go = (GameObject)Instantiate(Resources.Load("pattern01_shot"));
					go.transform.Translate (transform.position.x,
					                        transform.position.y,
					                        transform.position.z);
					go.transform.Rotate(0,0,180);
					go.transform.Rotate(0,0,angle);
				}
			} else {
				angle = 40;
				lr = true;
			}
		}

		//damage sprite issues
		if(frame_swap > 0) {
			frame_swap--;
			if(frame_swap == 0) {
				show_good();
			}
		} else if(frame_swap == 0) {
			show_good ();
		}
	}
}
