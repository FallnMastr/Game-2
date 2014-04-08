using UnityEngine;
using System.Collections;
using System;

public class water_boss : enemy_hit {

	int count = 0;
    int fire_limiter = 25;

	System.Random rand = new System.Random();
    

	// Use this for initialization
	void Start () {
		if(level_manager.bossHasRelic == true){
			gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("water-boss-relic");
			health = 300;
		} else {
			health = 200;
		}
		points = 2000;

		transform.Translate (new Vector3 (0, 10, 0));

        Vector3 pos = gameObject.transform.position;
        pos.z++;
	}
	
	// Update is called once per frame
	void Update () {

		if(level_manager.bossRun) {
			if(level_manager.bossHasRelic == true) {
				health = 300;
			} else {
				health = 200;
			}
			gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(-20,10,0),.07f);
			
            if(gameObject.transform.position == new Vector3(-20,10,0)) {
				level_manager.levelFinished = true;
			}

		} else {
            if (transform.position.y > 4) {
                if(level_manager.bossHasRelic == true){
			        health = 300;
		        }
		        else{
			        health = 200;
		        }
			    transform.Translate(Vector3.down * Time.deltaTime * 1);
            } else if (transform.position.y < -10) {
                UnityEngine.Object.Destroy(gameObject);
		    } else {
			    if (Time.timeScale != 0) {
		            count++;
                }

                if (count % fire_limiter == 0) {
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

                // Attack
                if (count % 500 == 0) {
                    GameObject go0 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go0.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go0.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go1.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go1.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go2.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go2.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go3.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go3.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go4.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go4.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go5.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go5.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go6.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go6.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go7 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go7.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go7.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go8 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go8.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go8.transform.Rotate(0,0,rand.Next(0,180)-90);
                    GameObject go9 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go9.transform.Translate(transform.position.x,
                                            transform.position.y,
                                            transform.position.z);
                    go9.transform.Rotate(0,0,rand.Next(0,180)-90);
                }
		    }

            if (count >= 10000) {
                transform.Translate(Vector3.down * Time.deltaTime * 5);
            }
        }
	}
}
