using UnityEngine;
using System.Collections;

public class forest_boss : enemy_hit {

	int count = 0;
    int fire_limiter = 50;
    int mult1, mult2;

    System.Random rand = new System.Random();

	// Use this for initialization
	void Start () {
		if(level_manager.bossHasRelic == true) {
			gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("earth-boss-relic");
			health = 800;
            mult1 = 1;
            mult2 = 2;
		} else {
			health = 600;
            mult1 = 0;
            mult2 = 0;
		}

     
		points = 2000;

		transform.Translate (new Vector3 (0, 10, 0));
		//transform.Rotate (new Vector3 (0, 0, 180));
	}
	
	// Update is called once per frame
	void Update () {
		if(level_manager.bossRun){
			if(level_manager.bossHasRelic == true){
				health = 800;
			}
			else{
				health = 600;
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
			        health = 800;
		        }
		        else{
			        health = 600;
		        }
				transform.Translate(Vector3.down * Time.deltaTime * 1);
	        } else if (transform.position.y < -10) {
	            UnityEngine.Object.Destroy(gameObject);
			} else {
				if (Time.timeScale != 0) {
		            count++;
                }

	            // Attack Mode 1
	            if (health > 500 + (mult2 * 50)) {
	                if (fire == 0) {
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_shot"));
	                    go1.transform.Translate(-5, transform.position.y, transform.position.z);
	                    GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_shot"));
	                    go2.transform.Translate(5, transform.position.y, transform.position.z);

						if (GameObject.Find("player2(Clone)") != null) {
                            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                            go01.transform.Translate(-5, transform.position.y, transform.position.z);
                            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                            go02.transform.Translate(5, transform.position.y, transform.position.z);
                        }
	                }

	                if (count % 500 == 10 || count % 500 == 20 || count % 500 == 30 || count % 500 == 40 || count % 500 == 50 ||
	                    count % 500 == 60 || count % 500 == 70 || count % 500 == 80 || count % 500 == 90 || count % 500 == 100) {
	                    GameObject go = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go.transform.Translate(transform.position.x,
	                                           transform.position.y,
	                                           transform.position.z);
	                }
	            // Attack Mode 2
	            } else if (health > 250 + (mult1 * 50) && health <= 500 + (mult1 * 50)) {
	                if (fire == 0 || fire == 3 || fire == 6 || fire == 9 || fire == 12) {
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_shot"));
	                    go1.transform.Translate(-5, transform.position.y, transform.position.z);
	                    GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_shot"));
	                    go2.transform.Translate(5, transform.position.y, transform.position.z);

						if (GameObject.Find("player2(Clone)") != null) {
                            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                            go01.transform.Translate(-5, transform.position.y, transform.position.z);
                            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                            go02.transform.Translate(5, transform.position.y, transform.position.z);
                        }
	                }

	                if (count % 300  == 0 || count % 300 == 25 || count % 300 == 50) {
	                    GameObject go = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go.transform.Translate(transform.position.x,
	                                           transform.position.y,
	                                           transform.position.z);
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go1.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go1.transform.Rotate(0, 0, -5);
	                    GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go2.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go2.transform.Rotate(0, 0, 5);
	                    GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go3.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go3.transform.Rotate(0, 0, -10);
	                    GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go4.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go4.transform.Rotate(0, 0, 10);
	                    GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go5.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go5.transform.Rotate(0, 0, -15);
	                    GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go6.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go6.transform.Rotate(0, 0, 15);
	                    GameObject go7 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go7.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go7.transform.Rotate(0, 0, -20);
	                    GameObject go8 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go8.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go8.transform.Rotate(0, 0, 20);
	                    GameObject go9 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go9.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go9.transform.Rotate(0, 0, -25);
	                    GameObject go0 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go0.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go0.transform.Rotate(0, 0, 25);
	                }
	            // Attack Mode 3
	            } else {
	                if (fire == 0) {
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go1.transform.Translate(-5, transform.position.y, transform.position.z);
	                    GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go2.transform.Translate(5, transform.position.y, transform.position.z);
	                }
	                
	                if (fire == 0 || fire == 3 || fire == 6 || fire == 9 || fire == 12) {
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_shot"));
	                    go1.transform.Translate(-5, transform.position.y, transform.position.z);
	                    GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_shot"));
	                    go2.transform.Translate(5, transform.position.y, transform.position.z);

						if (GameObject.Find("player2(Clone)") != null) {
                            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                            go01.transform.Translate(-5, transform.position.y, transform.position.z);
                            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_shot"));
                            go02.transform.Translate(5, transform.position.y, transform.position.z);
                        }
	                }

	                if (count % 300  == 0 || count % 300 == 25 || count % 300 == 50 || count % 300 == 75 || count % 300 == 100) {
	                    GameObject go = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go.transform.Translate(transform.position.x,
	                                           transform.position.y,
	                                           transform.position.z);
	                    GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go1.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go1.transform.Rotate(0, 0, -5);
	                    GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go2.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go2.transform.Rotate(0, 0, 5);
	                    GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go3.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go3.transform.Rotate(0, 0, -10);
	                    GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go4.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go4.transform.Rotate(0, 0, 10);
	                    GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go5.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go5.transform.Rotate(0, 0, -15);
	                    GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go6.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go6.transform.Rotate(0, 0, 15);
	                    GameObject go7 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go7.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go7.transform.Rotate(0, 0, -20);
	                    GameObject go8 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go8.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go8.transform.Rotate(0, 0, 20);
	                    GameObject go9 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go9.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go9.transform.Rotate(0, 0, -25);
	                    GameObject go0 = (GameObject)Instantiate(Resources.Load("vert_shot"));
	                    go0.transform.Translate(transform.position.x,
	                                            transform.position.y,
	                                            transform.position.z);
	                    go0.transform.Rotate(0, 0, 25);
	                }
	            }
			}

	        if (count >= 10000) {
	            transform.Translate(Vector3.down * Time.deltaTime * 5);
	        }
		}

	}
}