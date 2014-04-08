using UnityEngine;
using System.Collections;

public class city_boss : enemy_hit {

	int count = 0;
    int fire_limiter = 50;
    int mult;

    System.Random rand = new System.Random();

	// Use this for initialization
	void Start () {
		Debug.Log (level_manager.bossHasRelic);
		if(level_manager.bossHasRelic == true){
			gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("city-boss-relic");
			health = 600;
            mult = 1;
		}
		else{
			health = 500;
            mult = 0;
		}

	
		points = 2000;

		transform.Translate (new Vector3 (0, 10, 0));
		//transform.Rotate (new Vector3 (0, 0, 180));

	}
	
	// Update is called once per frame
	void Update () {
		if(level_manager.bossRun){
			if(level_manager.bossHasRelic == true){
				health = 600;
			}
			else{
				health = 500;
			}
			//	relic.gameObject.transform.position = Vector3.MoveTowards(relic.gameObject.transform.position, new Vector3(-20,10,0),.07f);
			gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(-20,10,0),.07f);
			
			if(gameObject.transform.position == new Vector3(-20,10,0)) {
				level_manager.levelFinished = true;
			}
			
		}
		else{

	        int fire = count % fire_limiter;

			if (transform.position.y > 4) {
                if(level_manager.bossHasRelic == true){
			        health = 600;
		        }
		        else{
			        health = 500;
		        }
				transform.Translate(Vector3.down * Time.deltaTime * 1);
	        } else if (transform.position.y < -10) {
	            UnityEngine.Object.Destroy(gameObject);
			} else {
				if (Time.timeScale != 0) {
		            count++;
                }

	            // Attack Mode 1
	            if (health > 250 + (mult * 50)) {
	                if (fire == 0 || fire == 25) {
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_shot"));
	                    go1.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);

						if (GameObject.Find("player2(Clone)") != null) {
                            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                            go2.transform.Translate(transform.position.x,
                                                    transform.position.y,
                                                    transform.position.z);
                        }
	                }

	                if (count % 500 == 0) {
	                    GameObject go0 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go0.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go0.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go1.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go1.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go2.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go2.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go3.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go3.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go4.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go4.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go5.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go5.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go6.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go6.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go7 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go7.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go7.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go8 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go8.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go8.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                    GameObject go9 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go9.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go9.transform.Rotate(0, 0, rand.Next(0, 180) - 90);
	                }
	            // Attack Mode 2
	            } else {
	                if (fire == 0 || fire == 3 || fire == 6 || fire == 9 || fire == 12) {
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_shot"));
	                    go1.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);

						if (GameObject.Find("player2(Clone)") != null) {
                            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                            go2.transform.Translate(transform.position.x,
                                                    transform.position.y,
                                                    transform.position.z);
                        }
	                }

	                if (count % 200 == 0  || count % 200 == 5  || count % 200 == 10 || count % 200 == 15 || count % 200 == 20 ||
	                    count % 200 == 25 || count % 200 == 30 || count % 200 == 35 || count % 200 == 40 || count % 200 == 45) {
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go1.transform.Translate(-5, transform.position.y, transform.position.z);
	                    GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go2.transform.Translate(5, transform.position.y, transform.position.z);
	                }
	            }
			}

	        if (count >= 10000) {
	            transform.Translate(Vector3.down * Time.deltaTime * 5);
	        }
		}
	}
}
