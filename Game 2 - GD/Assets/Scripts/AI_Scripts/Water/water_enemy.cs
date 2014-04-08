using UnityEngine;
using System.Collections;

public class water_enemy : enemy_hit {

	int count = 0;
	int fire_limiter = 75;
    int fire;

    enemy_health_script h = new enemy_health_script();
    enemy_score_script p = new enemy_score_script();
    
	// Use this for initialization
	void Start () {
		points = p.generateScore("water");
        health = h.generateHealth("water");

		transform.Translate (new Vector3 (0, 7, 0));

        loadSprite();
	}
	
	// Update is called once per frame
	void Update () {
        fire = count % fire_limiter;

		if (transform.position.y > 5) {
            health = h.generateHealth("water");
			transform.Translate(Vector3.down * Time.deltaTime * 3);
		} else if (transform.position.y < -10) {
			UnityEngine.Object.Destroy (gameObject);
		} else {
			if (Time.timeScale != 0) {
                count++;
            }

			if (count >= 5000) {
				if (count == 5000) {
					GameObject go = (GameObject)Instantiate(Resources.Load("towards_shot"));
                    go.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_shot"));
                    go1.transform.Translate(transform.position.x,
                                             transform.position.y,
                                             transform.position.z);
                    go1.transform.Rotate(0, 0, -5);
                    GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_shot"));
                    go2.transform.Translate(transform.position.x,
                                             transform.position.y,
                                             transform.position.z);
                    go2.transform.Rotate(0, 0, 5);
                    GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_shot"));
                    go3.transform.Translate(transform.position.x,
                                             transform.position.y,
                                             transform.position.z);
                    go3.transform.Rotate(0, 0, -10);
                    GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_shot"));
                    go4.transform.Translate(transform.position.x,
                                             transform.position.y,
                                             transform.position.z);
                    go4.transform.Rotate(0, 0, 10);

					if (GameObject.Find("player2(Clone)") != null) {
                        GameObject go0 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                        go0.transform.Translate(transform.position.x,
                                                transform.position.y,
                                                transform.position.z);
                        GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                        go01.transform.Translate(transform.position.x,
                                                 transform.position.y,
                                                 transform.position.z);
                        go01.transform.Rotate(0, 0, -5);
                        GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                        go02.transform.Translate(transform.position.x,
                                                 transform.position.y,
                                                 transform.position.z);
                        go02.transform.Rotate(0, 0, 5);
                        GameObject go03 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                        go03.transform.Translate(transform.position.x,
                                                 transform.position.y,
                                                 transform.position.z);
                        go03.transform.Rotate(0, 0, -10);
                        GameObject go04 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                        go04.transform.Translate(transform.position.x,
                                                 transform.position.y,
                                                 transform.position.z);
                        go04.transform.Rotate(0, 0, 10);
                    }
				}
				transform.Translate (Vector3.down * Time.deltaTime * 5);
			} else if (fire == 0) { // || fire == 3 || fire == 6 || fire == 9 || fire == 12){
				GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_shot"));
				go1.transform.Translate (transform.position.x,
					                    transform.position.y,
					                    transform.position.z);

				if (GameObject.Find("player2(Clone)") != null) {
                    GameObject go2 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                    go2.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                }
			}
		}

        //damage sprite issues
		if(frame_swap > 0) {
			if (Time.timeScale != 0) {
			    frame_swap--;
            }
			if(frame_swap == 0) {
				show_good();
			}
		} else if(frame_swap == 0) {
			show_good ();
		}
	}
}