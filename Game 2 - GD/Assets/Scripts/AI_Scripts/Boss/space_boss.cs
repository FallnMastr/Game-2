using UnityEngine;
using System.Collections;
using System;

public class space_boss : enemy_hit {

	int count = 0;
    int fire_limiter = 50;
    int fire_limiter_middle = 5;
    int fire_limiter_side = 10;

    int angle1 = 5;
    int angle2 = -35;
    int angle3 = 35;
    int angle4 = -5;
    bool lr1 = false;		// True is right, false is left.
    bool lr2 = false;
    bool lr3 = true;
    bool lr4 = true;

    System.Random rand = new System.Random();

	// Use this for initialization
	void Start () {
        health = 1200;
		points = 2000;

		transform.Translate (new Vector3 (0, 10, 0));
		//transform.Rotate (new Vector3 (0, 0, 180));
	}
	
	// Update is called once per frame
	void Update () {
        int fire = count % fire_limiter;

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        float yneg = Convert.ToSingle(transform.position.y - 3.075);

        if (angle1 == 0) lr1 = true; else if (angle1 == 90) lr1 = false;
        if (angle2 == 45) lr2 = false; else if (angle2 == -45) lr2 = true;
        if (angle3 == 45) lr3 = false; else if (angle3 == -45) lr3 = true;
        if (angle4 == 0) lr4 = false; else if (angle4 == -90) lr4 = true;

		if (transform.position.y > 4) {
            health = 1200;
			transform.Translate(Vector3.down * Time.deltaTime * 1);
        } else if (transform.position.y < -10) {
            UnityEngine.Object.Destroy(gameObject);
		} else {
			if (Time.timeScale != 0) {
		        count++;
            }

            // Attack Mode 1
            if (health > 1000) {
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

                if (count % 300 == 0) {
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
            } else if (health > 750 && health <= 1000) {
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

                if (count % 300 == 10 || count % 300 == 20 || count % 300 == 30 || count % 300 == 40 || count % 300 == 50 ||
                    count % 300 == 60 || count % 300 == 70 || count % 300 == 80 || count % 300 == 90 || count % 300 == 100) {
                    GameObject go = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go.transform.Translate(transform.position.x,
                                           transform.position.y,
                                           transform.position.z);
                }
            // Attack Mode 3
            } else if (health > 500 && health <= 750) {
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

                if (count % 500 < 95) {
				    if(count % fire_limiter_side == 0){
					    if (lr1) angle1 += 10; else angle1 -= 10;
					    if (lr4) angle4 += 10; else angle4 -= 10;
					
					    GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_shot"));
					    go1.transform.Translate(-5,yneg,z);
					    //go1.transform.Rotate(0,0,180);
					    go1.transform.Rotate(0,0,angle1);

					    GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_shot"));
					    go4.transform.Translate(5,yneg,z);
					    //go4.transform.Rotate(0,0,180);
					    go4.transform.Rotate(0,0,angle4);
				    }
			    } else {
				    angle1 =  10; lr1 = false;
				    angle4 = -10; lr4 =  true;
			    }
            // Attack Mode 4
            } else if (health > 250 && health <= 500) {
                if (count % 500 == 50 || count % 500 == 100 || count % 500 == 150 || count % 500 == 200 || count % 500 == 250) {
                    GameObject go00 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go00.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go00.transform.Rotate(0, 0, 0);
                    GameObject go01 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go01.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go01.transform.Rotate(0, 0, -10);
                    GameObject go02 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go02.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go02.transform.Rotate(0, 0, 10);
                    GameObject go03 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go03.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go03.transform.Rotate(0, 0, -20);
                    GameObject go04 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go04.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go04.transform.Rotate(0, 0, 20);
                    GameObject go05 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go05.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go05.transform.Rotate(0, 0, -30);
                    GameObject go06 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go06.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go06.transform.Rotate(0, 0, 30);
                    GameObject go07 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go07.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go07.transform.Rotate(0, 0, -40);
                    GameObject go08 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go08.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go08.transform.Rotate(0, 0, 40);
                    GameObject go09 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go09.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go09.transform.Rotate(0, 0, -50);
                    GameObject go10 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go10.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go10.transform.Rotate(0, 0, 50);
                    GameObject go11 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go11.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go11.transform.Rotate(0, 0, -60);
                    GameObject go12 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go12.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go12.transform.Rotate(0, 0, 60);
                    GameObject go13 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go13.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go13.transform.Rotate(0, 0, -70);
                    GameObject go14 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go14.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go14.transform.Rotate(0, 0, 70);
                    GameObject go15 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go15.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go15.transform.Rotate(0, 0, -80);
                    GameObject go16 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go16.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go16.transform.Rotate(0, 0, 80);
                    GameObject go17 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go17.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go17.transform.Rotate(0, 0, -90);
                    GameObject go18 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go18.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go18.transform.Rotate(0, 0, 90);
                    GameObject go19 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go19.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go19.transform.Rotate(0, 0, -100);
                    GameObject go20 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go20.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go20.transform.Rotate(0, 0, 100);
                    GameObject go21 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go21.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go21.transform.Rotate(0, 0, -110);
                    GameObject go22 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go22.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go22.transform.Rotate(0, 0, 110);
                    GameObject go23 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go23.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go23.transform.Rotate(0, 0, -120);
                    GameObject go24 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go24.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go24.transform.Rotate(0, 0, 120);
                    GameObject go25 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go25.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go25.transform.Rotate(0, 0, -130);
                    GameObject go26 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go26.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go26.transform.Rotate(0, 0, 130);
                    GameObject go27 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go27.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go27.transform.Rotate(0, 0, -140);
                    GameObject go28 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go28.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go28.transform.Rotate(0, 0, 140);
                    GameObject go29 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go29.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go29.transform.Rotate(0, 0, -150);
                    GameObject go30 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go30.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go30.transform.Rotate(0, 0, 150);
                    GameObject go31 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go31.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go31.transform.Rotate(0, 0, -160);
                    GameObject go32 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go32.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go32.transform.Rotate(0, 0, 160);
                    GameObject go33 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go33.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go33.transform.Rotate(0, 0, -170);
                    GameObject go34 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go34.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go34.transform.Rotate(0, 0, 170);
                    GameObject go35 = (GameObject)Instantiate(Resources.Load("vert_shot"));
                    go35.transform.Translate(transform.position.x, transform.position.y, transform.position.z);
                    go35.transform.Rotate(0, 0, 180);
                }

                if (count % 100 == 0 || count % 100 == 3 || count % 100 == 6 || count % 100 == 9 || count % 100 == 12) {
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
            // Attack Mode 5
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

                if (count % 300 < 73) {
				    if(count % fire_limiter_middle == 0){
					    if (lr2) angle2 += 10; else angle2 -= 10;
					    if (lr3) angle3 += 10; else angle3 -= 10;
					
					    GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_shot"));
					    go2.transform.Translate(x,yneg,z);
					    //go2.transform.Rotate(0,0,180);
					    go2.transform.Rotate(0,0,angle2);

					    GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_shot"));
					    go3.transform.Translate(x,yneg,z);
					    //go3.transform.Rotate(0,0,180);
					    go3.transform.Rotate(0,0,angle3);
				    }
			    } else {
				    angle2 = -35; lr2 = false;
				    angle3 =  35; lr3 =  true;
			    }
            }
		}

        if (count >= 10000) {
            transform.Translate(Vector3.down * Time.deltaTime * 5);
        }

	}
}