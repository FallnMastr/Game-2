using UnityEngine;
using System.Collections;

public class water_path : enemy_hit {

    int fire;
    int count = 0;
    int fire_limiter = 75;
    bool onPath = false;
    bool vert = true;   // true is down, false is up
    bool horiz = true;  // true is right, false is left

    enemy_health_script h = new enemy_health_script();
    enemy_score_script p = new enemy_score_script();

    // Use this for initialization
    void Start()
    {
        points = p.generateScore("water");
        health = h.generateHealth("water");

        transform.Translate(new Vector3(0, 7, 0));

        loadSprite();
    }
	
	// Update is called once per frame
	void Update () {
        fire = count % fire_limiter;

	    if (!onPath) {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5, 3, 0), 3 * Time.deltaTime);
        } else {
            transform.Translate(Vector3.left * Time.deltaTime * 3);

            if (Time.timeScale != 0) {
                count++;
            }

            if (count >= 5000) {
		        if (count == 5000) {
                    GameObject go = (GameObject)Instantiate(Resources.Load("vert_shot"));
					go.transform.Translate (transform.position.x,
					                        transform.position.y,
					                        transform.position.z);
					GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_shot"));
					go1.transform.Translate (transform.position.x,
					                        transform.position.y,
					                        transform.position.z);
					go1.transform.Rotate (0,0,-5);
					GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_shot"));
					go2.transform.Translate (transform.position.x,
					                        transform.position.y,
					                        transform.position.z);
					go2.transform.Rotate (0,0,5);
					GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_shot"));
					go3.transform.Translate (transform.position.x,
					                        transform.position.y,
					                        transform.position.z);
					go3.transform.Rotate (0,0,-10);
					GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_shot"));
					go4.transform.Translate (transform.position.x,
					                        transform.position.y,
					                        transform.position.z);
					go4.transform.Rotate (0,0,10);
		        }
                if (vert && horiz) {
                    transform.Rotate(0, 0, -90);
                    horiz = false;
                } else if (!vert && horiz) {
                    transform.Rotate(0, 0, 180);
                    vert = true;
                    horiz = false;
                } else if (!vert && !horiz) {
                    transform.Rotate(0, 0, 90);
                    vert = true;
                }

		        transform.Translate (Vector3.down * Time.deltaTime * 5);
	        } else {
                if (fire == 0) { // || fire == 3 || fire == 6 || fire == 9 || fire == 12){
		            GameObject go = (GameObject)Instantiate(Resources.Load("vert_shot"));
		            go.transform.Translate (transform.position.x,
					                        transform.position.y,
					                        transform.position.z);

                    if (vert && horiz) {
                        go.transform.Rotate(0, 0, 90);
                    } else if (!vert && horiz) {
                        go.transform.Rotate(0, 0, 180);
                    } else if (!vert && !horiz) {
                        go.transform.Rotate(0, 0, -90);
                    }
                }

                if (vert && horiz) {
                    if (transform.position.y < -3) {
                        transform.Rotate(0, 0, 90);
                        vert = false;
                    }
                } else if (!vert && horiz) {
                    if (transform.position.x > 5) {
                        transform.Rotate(0, 0, 90);
                        horiz = false;
                    }
                } else if (!vert && !horiz) {
                    if (transform.position.y > 3) {
                        transform.Rotate(0, 0, 90);
                        vert = true;
                    }
                } else if (vert && !horiz) {
                    if (transform.position.x < -5) {
                        transform.Rotate(0, 0, 90);
                        horiz = true;
                    }
                }
	        }
        }

        if (transform.position.x == -5 && transform.position.y == 3) {
            transform.Rotate(0, 0, 90);
            onPath = true;
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
