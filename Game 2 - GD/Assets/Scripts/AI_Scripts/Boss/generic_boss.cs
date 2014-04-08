using UnityEngine;
using System.Collections;
using System;

public class generic_boss : enemy_hit {

	int count = 0;
	int fire_limiter_middle = 1;
	int fire_limiter_side = 5;
	
	int angle1 =   5;
	int angle2 = -40;
	int angle3 =  40;
	int angle4 =  -5;
	bool lr1 = false;		// True is right, false is left.
	bool lr2 = false;
	bool lr3 =  true;
	bool lr4 =  true;

	// Use this for initialization
	void Start () {

		health = 1000;
		points = 200;

		transform.Translate (new Vector3 (0, 10, 0));
		//transform.Rotate (new Vector3 (0, 0, 180));
	}
	
	// Update is called once per frame
	void Update () {
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		float xneg = Convert.ToSingle (transform.position.x - 4.125);
		float xpos = Convert.ToSingle (transform.position.x + 4.125);
		float yneg = Convert.ToSingle (transform.position.y - 3.075);

		if (angle1 ==  0)  lr1 =  true; else if (angle1 ==  90) lr1 = false;
		if (angle2 == 45)  lr2 = false; else if (angle2 == -45) lr2 =  true;
		if (angle3 == 45)  lr3 = false; else if (angle3 == -45) lr3 =  true;
		if (angle4 ==  0)  lr4 = false; else if (angle4 == -90) lr4 =  true;

		if (transform.position.y > 5) {
			transform.Translate(Vector3.down * Time.deltaTime * 1);
		} else {
			if (Time.timeScale != 0) {
		        count++;
            }
			if (count == 3900) {
				count = 0;
			}
			
			if (count % 200 < 73) {
				if(count % fire_limiter_middle == 0){
					if (lr2) angle2 += 5; else angle2 -= 5;
					if (lr3) angle3 += 5; else angle3 -= 5;
					
					GameObject go2 = (GameObject)Instantiate(Resources.Load("pattern01_shot"));
					go2.transform.Translate(x,yneg,z);
					//go2.transform.Rotate(0,0,180);
					go2.transform.Rotate(0,0,angle2);

					GameObject go3 = (GameObject)Instantiate(Resources.Load("pattern01_shot"));
					go3.transform.Translate(x,yneg,z);
					//go3.transform.Rotate(0,0,180);
					go3.transform.Rotate(0,0,angle3);
				}
			} else {
				angle2 = -40; lr2 = false;
				angle3 =  40; lr3 =  true;
			}

			if (count % 390 < 95) {
				if(count % fire_limiter_side == 0){
					if (lr1) angle1 += 5; else angle1 -= 5;
					if (lr4) angle4 += 5; else angle4 -= 5;
					
					GameObject go1 = (GameObject)Instantiate(Resources.Load("pattern01_shot"));
					go1.transform.Translate(xneg,yneg,z);
					//go1.transform.Rotate(0,0,180);
					go1.transform.Rotate(0,0,angle1);

					GameObject go4 = (GameObject)Instantiate(Resources.Load("pattern01_shot"));
					go4.transform.Translate(xpos,yneg,z);
					//go4.transform.Rotate(0,0,180);
					go4.transform.Rotate(0,0,angle4);
				}
			} else {
				angle1 =  5; lr1 = false;
				angle4 = -5; lr4 =  true;
			}
		}
	}
}
