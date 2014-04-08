using UnityEngine;
using System.Collections;
using System;

public class final_level : MonoBehaviour {

	int time = 0;
    int plus = 0;
    int overall = 0;
    bool wave01 =  true, wave02 = false, wave03 = false,
         wave04 = false, wave05 = false, wave06 = false,
         wave07 = false, wave08 = false, wave09 = false,
         wave10 = false, wave11 = false, wave12 = false,
         wave13 = false, wave14 = false, wave15 = false,
         wave16 = false, wave17 = false, wave18 = false,
         wave19 = false, wave20 = false,
         waveB1 = false, waveB2 = false, waveB3 = false,
         waveB4 = false;
    bool comp01 = false, comp02 = false, comp03 = false,
         comp04 = false, comp05 = false, comp06 = false,
         comp07 = false, comp08 = false, comp09 = false,
         comp10 = false, comp11 = false, comp12 = false,
         comp13 = false, comp14 = false, comp15 = false,
         comp16 = false, comp17 = false, comp18 = false,
         comp19 = false, comp20 = false,
         compB1 = false, compB2 = false, compB3 = false,
         compB4 = false;

    public KeyCode p;

	// Use this for initialization
	void Start () {
        p = KeyCode.KeypadPlus;
	}
	
	// Update is called once per frame
	void Update () {
        bool next = Input.GetKey(p);
        
        if (Time.timeScale != 0) {
            if (next) plus++;
            else plus = 0;
        }

        if (plus == 1) time = 5500;

        // spawning waves
		if (wave01) {
            Debug.Log("wave 1");
			// spawn wave 1
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(-3, 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(3, 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(5, 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go5.transform.Translate(-4, 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go6.transform.Translate(4, 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("water_path"));
            go7.transform.Translate(0, 1, 0);*/

            /*GameObject go0 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go0.transform.Translate(-5, 1, 0);
            GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go1.transform.Translate(Convert.ToSingle(-3.89), 2, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go2.transform.Translate(Convert.ToSingle(-2.78), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go3.transform.Translate(Convert.ToSingle(-1.67), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.56), 2, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.56), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go6.transform.Translate(Convert.ToSingle(1.67), 2, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go7.transform.Translate(Convert.ToSingle(2.78), 1, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go8.transform.Translate(Convert.ToSingle(3.89), 0, 0);
            GameObject go9 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go9.transform.Translate(5, 1, 0);*/

            wave01 = false;
            time = 0;
		} else if (wave02) {
            Debug.Log("wave 2");
			// spawn wave 2
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("water_enemy"));
            go1.transform.Translate(-5, 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("waterb_enemy"));
            go2.transform.Translate(-3, 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("waterb_enemy"));
            go3.transform.Translate(-1, 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("waterb_enemy"));
            go4.transform.Translate(1, 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("waterb_enemy"));
            go5.transform.Translate(3, 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("water_enemy"));
            go6.transform.Translate(5, 0, 0);*/

            wave02 = false;
            time = 0;
		} else if (wave03) {
            Debug.Log("wave 3");
			// spawn wave 3
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go2.transform.Translate(-3, 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("waterb_enemy"));
            go3.transform.Translate(-1, 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("waterb_enemy"));
            go4.transform.Translate(1, 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go5.transform.Translate(3, 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(5, 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("water_path"));
            go7.transform.Translate(0, 1, 0);*/

            wave03 = false;
            time = 0;
		} else if (wave04) {
            Debug.Log("wave 4");
			// spawn wave 4
            /*GameObject go01 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go01.transform.Translate(-5, 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go02.transform.Translate(-3, 1, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("waterb_enemy"));
            go03.transform.Translate(-1, 1, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("waterb_enemy"));
            go04.transform.Translate(1, 1, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go05.transform.Translate(3, 1, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go06.transform.Translate(5, 1, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(-4, 0, 0);
            GameObject go08 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go08.transform.Translate(4, 0, 0);

            GameObject go09 = (GameObject)Instantiate(Resources.Load("water_path"));
            go09.transform.Translate(0, 0, 0);
            GameObject go10 = (GameObject)Instantiate(Resources.Load("water_path"));
            go10.transform.Translate(0, 3, 0);
            GameObject go11 = (GameObject)Instantiate(Resources.Load("water_path"));
            go11.transform.Translate(0, 6, 0);*/

            wave04 = false;
            time = 0;
		} else if (wave05) {
            Debug.Log("wave 5");
			// spawn wave 5
            /*GameObject go01 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go01.transform.Translate(-5, 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go02.transform.Translate(-3, 1, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go03.transform.Translate(3, 1, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go04.transform.Translate(5, 1, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go05.transform.Translate(-4, 0, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go06.transform.Translate(4, 0, 0);

            GameObject go07 = (GameObject)Instantiate(Resources.Load("water_path"));
            go07.transform.Translate(0, 0, 0);
            GameObject go08 = (GameObject)Instantiate(Resources.Load("waterb_path"));
            go08.transform.Translate(0, 3, 0);
            GameObject go09 = (GameObject)Instantiate(Resources.Load("water_path"));
            go09.transform.Translate(0, 6, 0);
            GameObject go10 = (GameObject)Instantiate(Resources.Load("waterb_path"));
            go10.transform.Translate(0, 9, 0);
            GameObject go11 = (GameObject)Instantiate(Resources.Load("water_path"));
            go11.transform.Translate(0, 12, 0);
            GameObject go12 = (GameObject)Instantiate(Resources.Load("waterb_path"));
            go12.transform.Translate(0, 15, 0);*/

            wave05 = false;
            time = 0;
        } else if (waveB1) {
            Debug.Log("water boss");
			// spawn boss
            /*GameObject goB = (GameObject)Instantiate(Resources.Load("water_boss"));
            goB.transform.Translate(0, 0, 0);*/
            waveB1 = false;
            time = 0;
		} else if (wave06) {
            Debug.Log("wave 6");
            // spawn wave 6
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.33), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(3.33), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(5, 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go5.transform.Translate(Convert.ToSingle(-4.17), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go6.transform.Translate(Convert.ToSingle(-2.5), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go7.transform.Translate(Convert.ToSingle(2.5), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go8.transform.Translate(Convert.ToSingle(4.17), 0, 0);
            GameObject go9 = (GameObject)Instantiate(Resources.Load("city_path"));
            go9.transform.Translate(0, 1, 0);*/

            wave06 = false;
            time = 0;
        } else if (wave07) {
            Debug.Log("wave 7");
            // spawn wave 7
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("city_enemy"));
            go1.transform.Translate(-5, 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("cityb_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.33), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("cityb_enemy"));
            go3.transform.Translate(Convert.ToSingle(-1.67), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("city_enemy"));
            go4.transform.Translate(0, 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("cityb_enemy"));
            go5.transform.Translate(Convert.ToSingle(1.67), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("cityb_enemy"));
            go6.transform.Translate(Convert.ToSingle(3.33), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("city_enemy"));
            go7.transform.Translate(5, 0, 0);*/

            wave07 = false;
            time = 0;
        } else if (wave08) {
            Debug.Log("wave 8");
            // spawn wave 8
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("cityb_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.33), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("cityb_enemy"));
            go3.transform.Translate(Convert.ToSingle(3.33), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(5, 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("city_path"));
            go5.transform.Translate(0, 1, 0);*/

            wave08 = false;
            time = 0;
        } else if (wave09) {
            Debug.Log("wave 9");
            // spawn wave 9
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.33), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("cityb_enemy"));
            go3.transform.Translate(Convert.ToSingle(-1.67), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("city_enemy"));
            go4.transform.Translate(0, 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("cityb_enemy"));
            go5.transform.Translate(Convert.ToSingle(1.67), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(Convert.ToSingle(3.33), 1, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go7.transform.Translate(5, 1, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("city02_path"));
            go8.transform.Translate(0, 0, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.17), 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.5), 0, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go03.transform.Translate(Convert.ToSingle(2.5), 0, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go04.transform.Translate(Convert.ToSingle(4.17), 0, 0);*/

            wave09 = false;
            time = 0;
        } else if (wave10) {
            Debug.Log("wave 10");
            // spawn wave 10
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.33), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(3.33), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(5, 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("cityb_path"));
            go5.transform.Translate(0, 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("city02_path"));
            go6.transform.Translate(0, 0, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.17), 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.5), 0, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go03.transform.Translate(Convert.ToSingle(2.5), 0, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go04.transform.Translate(Convert.ToSingle(4.17), 0, 0);*/

            wave10 = false;
            time = 0;
        } else if (waveB2) {
            Debug.Log("city boss");
			// spawn boss
            /*GameObject goB = (GameObject)Instantiate(Resources.Load("city_boss"));
            goB.transform.Translate(0, 0, 0);*/
            waveB2 = false;
            time = 0;
        } else if (wave11) {
            Debug.Log("wave 11");
            // spawn wave 11
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(5, 1, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go7.transform.Translate(0, 1, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 0, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go03.transform.Translate(Convert.ToSingle(-1.43), 0, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go04.transform.Translate(0, 0, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go05.transform.Translate(Convert.ToSingle(1.43), 0, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go06.transform.Translate(Convert.ToSingle(2.86), 0, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(Convert.ToSingle(4.29), 0, 0);*/

            wave11 = false;
            time = 0;
        } else if (wave12) {
            Debug.Log("wave 12");
            // spawn wave 12
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go1.transform.Translate(-5, 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("forestb_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("forestb_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.71), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.71), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("forestb_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forestb_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go8.transform.Translate(5, 0, 0);*/

            wave12 = false;
            time = 0;
        } else if (wave13) {
            Debug.Log("wave 13");
            // spawn wave 13
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(5, 1, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forestb_path"));
            go7.transform.Translate(0, 1, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 0, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go03.transform.Translate(Convert.ToSingle(-1.43), 0, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go04.transform.Translate(0, 0, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go05.transform.Translate(Convert.ToSingle(1.43), 0, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go06.transform.Translate(Convert.ToSingle(2.86), 0, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(Convert.ToSingle(4.29), 0, 0);*/

            wave13 = false;
            time = 0;
        } else if (wave14) {
            Debug.Log("wave 14");
            // spawn wave 14
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(5, 1, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go7.transform.Translate(0, 1, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 0, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go03.transform.Translate(Convert.ToSingle(-1.43), 0, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go04.transform.Translate(0, 0, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go05.transform.Translate(Convert.ToSingle(1.43), 0, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go06.transform.Translate(Convert.ToSingle(2.86), 0, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(Convert.ToSingle(4.29), 0, 0);*/

            wave14 = false;
            time = 0;
        } else if (wave15) {
            Debug.Log("wave 15");
            // spawn wave 15
            /*GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(3.57), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(5, 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go5.transform.Translate(0, 1, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 0, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go03.transform.Translate(Convert.ToSingle(-1.43), 0, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go04.transform.Translate(0, 0, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go05.transform.Translate(Convert.ToSingle(1.43), 0, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go06.transform.Translate(Convert.ToSingle(2.86), 0, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(Convert.ToSingle(4.29), 0, 0);*/

            wave15 = false;
            time = 0;
        } else if (waveB3) {
            Debug.Log("forest boss");
			// spawn boss
            /*GameObject goB = (GameObject)Instantiate(Resources.Load("forest_boss"));
            goB.transform.Translate(0, 0, 0);*/
            waveB3 = false;
            time = 0;
        } else if (wave16) {
            Debug.Log("wave 16");
            // spawn wave 16
            /*GameObject go0 = (GameObject)Instantiate(Resources.Load("water02_enemy"));
            go0.transform.Translate(Convert.ToSingle(-4.44), 0, 0);
            GameObject go1 = (GameObject)Instantiate(Resources.Load("city02_enemy"));
            go1.transform.Translate(Convert.ToSingle(-3.33), 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("waterb02_enemy"));
            go2.transform.Translate(Convert.ToSingle(-2.22), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("cityb02_enemy"));
            go3.transform.Translate(Convert.ToSingle(-1.11), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("water02_enemy"));
            go4.transform.Translate(Convert.ToSingle(0), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("cityb02_enemy"));
            go5.transform.Translate(Convert.ToSingle(1.11), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("waterb02_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.22), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("city02_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.33), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("water02_enemy"));
            go8.transform.Translate(Convert.ToSingle(4.44), 0, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("water_path"));
            go01.transform.Translate(0, 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("city_path"));
            go02.transform.Translate(0, 1, 0);*/

            wave16 = false;
            time = 0;
        } else if (wave17) {
            Debug.Log("wave 17");
            // spawn wave 17
            /*GameObject go0 = (GameObject)Instantiate(Resources.Load("city02_enemy"));
            go0.transform.Translate(Convert.ToSingle(-4.44), 0, 0);
            GameObject go1 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go1.transform.Translate(Convert.ToSingle(-3.33), 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("cityb02_enemy"));
            go2.transform.Translate(Convert.ToSingle(-2.22), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go3.transform.Translate(Convert.ToSingle(-1.11), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("city02_enemy"));
            go4.transform.Translate(Convert.ToSingle(0), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go5.transform.Translate(Convert.ToSingle(1.11), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("cityb02_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.22), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.33), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("city02_enemy"));
            go8.transform.Translate(Convert.ToSingle(4.44), 0, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go01.transform.Translate(0, 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("city_path"));
            go02.transform.Translate(0, 1, 0);*/

            wave17 = false;
            time = 0;
        } else if (wave18) {
            Debug.Log("wave 18");
            // spawn wave 18
            /*GameObject go0 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go0.transform.Translate(Convert.ToSingle(-4.44), 0, 0);
            GameObject go1 = (GameObject)Instantiate(Resources.Load("water02_enemy"));
            go1.transform.Translate(Convert.ToSingle(-3.33), 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go2.transform.Translate(Convert.ToSingle(-2.22), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("waterb02_enemy"));
            go3.transform.Translate(Convert.ToSingle(-1.11), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go4.transform.Translate(Convert.ToSingle(0), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("waterb02_enemy"));
            go5.transform.Translate(Convert.ToSingle(1.11), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.22), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("water02_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.33), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go8.transform.Translate(Convert.ToSingle(4.44), 0, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go01.transform.Translate(0, 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("water_path"));
            go02.transform.Translate(0, 1, 0);*/

            wave18 = false;
            time = 0;
        } else if (wave19) {
            Debug.Log("wave 19");
            // spawn wave 19
            /*GameObject go0 = (GameObject)Instantiate(Resources.Load("water02_enemy"));
            go0.transform.Translate(Convert.ToSingle(-4.44), 0, 0);
            GameObject go1 = (GameObject)Instantiate(Resources.Load("city02_enemy"));
            go1.transform.Translate(Convert.ToSingle(-3.33), 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go2.transform.Translate(Convert.ToSingle(-2.22), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("water02_enemy"));
            go3.transform.Translate(Convert.ToSingle(-1.11), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go4.transform.Translate(Convert.ToSingle(0), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("city02_enemy"));
            go5.transform.Translate(Convert.ToSingle(1.11), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.22), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("city02_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.33), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("water02_enemy"));
            go8.transform.Translate(Convert.ToSingle(4.44), 0, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go01.transform.Translate(0, 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("city_path"));
            go02.transform.Translate(0, 1, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("water_path"));
            go03.transform.Translate(0, 1, 0);*/

            wave19 = false;
            time = 0;
        } else if (wave20) {
            Debug.Log("wave 20");
            // spawn wave 20
            /*GameObject go0 = (GameObject)Instantiate(Resources.Load("waterb02_enemy"));
            go0.transform.Translate(Convert.ToSingle(-4.44), 0, 0);
            GameObject go1 = (GameObject)Instantiate(Resources.Load("cityb02_enemy"));
            go1.transform.Translate(Convert.ToSingle(-3.33), 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go2.transform.Translate(Convert.ToSingle(-2.22), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("waterb02_enemy"));
            go3.transform.Translate(Convert.ToSingle(-1.11), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go4.transform.Translate(Convert.ToSingle(0), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("cityb02_enemy"));
            go5.transform.Translate(Convert.ToSingle(1.11), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.22), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("cityb02_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.33), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("waterb02_enemy"));
            go8.transform.Translate(Convert.ToSingle(4.44), 0, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("forestb_path"));
            go01.transform.Translate(0, 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("cityb_path"));
            go02.transform.Translate(0, 1, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("waterb_path"));
            go03.transform.Translate(0, 1, 0);*/

            wave20 = false;
            time = 0;
		} else if (waveB4) {
            Debug.Log("final boss");
			// spawn boss
            GameObject goB = (GameObject)Instantiate(Resources.Load("space_boss"));
            goB.transform.Translate(0, 0, 0);
            waveB4 = false;
            time = 0;
		}

        // switching waves
        if (comp01 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                   GameObject.Find("towards_enemy(Clone)") == null &&
                                                      GameObject.Find("water_path(Clone)") == null))) {
            comp01 = true;
            wave02 = true;
        } else if (comp01 == true && comp02 == false && (time == 5500 || (GameObject.Find("waterb_enemy(Clone)") == null &&
                                                                           GameObject.Find("water_enemy(Clone)") == null))) {
            comp02 = true;
            wave03 = true;
        } else if (comp02 == true && comp03 == false && (time == 5500 || (GameObject.Find("towards_enemy(Clone)") == null &&
                                                                           GameObject.Find("waterb_enemy(Clone)") == null &&
                                                                            GameObject.Find("water_enemy(Clone)") == null &&
                                                                             GameObject.Find("vert_enemy(Clone)") == null))) {
            comp03 = true;
            wave04 = true;
        } else if (comp03 == true && comp04 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                             GameObject.Find("waterb_enemy(Clone)") == null &&
                                                                               GameObject.Find("water_path(Clone)") == null))) {
            comp04 = true;
            wave05 = true;
        } else if (comp04 == true && comp05 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                              GameObject.Find("waterb_path(Clone)") == null &&
                                                                               GameObject.Find("water_path(Clone)") == null))) {
            comp05 = true;
            waveB1 = true;
        } else if (comp05 == true && compB1 == false && (time == 10500 || GameObject.Find("water_boss(Clone)") == null)) {
            compB1 = true;
            wave06 = true;
        } else if (compB1 == true && comp06 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                                GameObject.Find("city_path(Clone)") == null))) {
            comp06 = true;
            wave07 = true;
        } else if (comp06 == true && comp07 == false && (time == 5500 || (GameObject.Find("cityb_enemy(Clone)") == null &&
                                                                           GameObject.Find("city_enemy(Clone)") == null))) {
            comp07 = true;
            wave08 = true;
        } else if (comp07 == true && comp08 == false && (time == 5500 || (GameObject.Find("towards_enemy(Clone)") == null &&
                                                                            GameObject.Find("cityb_enemy(Clone)") == null &&
                                                                              GameObject.Find("city_path(Clone)") == null))) {
            comp08 = true;
            wave09 = true;
        } else if (comp08 == true && comp09 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                              GameObject.Find("cityb_enemy(Clone)") == null &&
                                                                              GameObject.Find("city02_path(Clone)") == null &&
                                                                               GameObject.Find("city_enemy(Clone)") == null))) {
            comp09 = true;
            wave10 = true;
        } else if (comp09 == true && comp10 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                              GameObject.Find("city02_path(Clone)") == null &&
                                                                               GameObject.Find("cityb_path(Clone)") == null))) {
            comp10 = true;
            waveB2 = true;
        } else if (comp10 == true && compB2 == false && (time == 10500 || GameObject.Find("city_boss(Clone)") == null)) {
            compB2 = true;
            wave11 = true;
        } else if (compB2 == true && comp11 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                             GameObject.Find("vert02_enemy(Clone)") == null &&
                                                                              GameObject.Find("forest_path(Clone)") == null))) {
            comp11 = true;
            wave12 = true;
        } else if (comp11 == true && comp12 == false && (time == 5500 || (GameObject.Find("forestb_enemy(Clone)") == null &&
                                                                           GameObject.Find("forest_enemy(Clone)") == null))) {
            comp12 = true;
            wave13 = true;
        } else if (comp12 == true && comp13 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                           GameObject.Find("forest02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                             GameObject.Find("forestb_path(Clone)") == null))) {
            comp13 = true;
            wave14 = true;
        } else if (comp13 == true && comp14 == false && (time == 5500 || (GameObject.Find("forestb02_enemy(Clone)") == null &&
                                                                          GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                              GameObject.Find("forest_path(Clone)") == null))) {
            comp14 = true;
            wave15 = true;
        } else if (comp14 == true && comp15 == false && (time == 5500 || (GameObject.Find("forestb02_enemy(Clone)") == null &&
                                                                          GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                              GameObject.Find("forest_path(Clone)") == null))) {
            comp15 = true;
            waveB3 = true;
        } else if (comp15 == true && compB3 == false && (time == 10500 || GameObject.Find("forest_boss(Clone)") == null)) {
            compB3 = true;
            wave16 = true;
        } else if (compB3 == true && comp16 == false && (time == 5500 || (GameObject.Find("waterb02_enemy(Clone)") == null &&
                                                                           GameObject.Find("water02_enemy(Clone)") == null &&
                                                                           GameObject.Find("cityb02_enemy(Clone)") == null &&
                                                                            GameObject.Find("city02_enemy(Clone)") == null &&
                                                                              GameObject.Find("water_path(Clone)") == null &&
                                                                               GameObject.Find("city_path(Clone)") == null)))
        {
            comp16 = true;
            wave17 = true;
        } else if (comp16 == true && comp17 == false && (time == 5500 || (GameObject.Find("forestb02_enemy(Clone)") == null &&
                                                                           GameObject.Find("forest02_enemy(Clone)") == null &&
                                                                            GameObject.Find("cityb02_enemy(Clone)") == null &&
                                                                             GameObject.Find("city02_enemy(Clone)") == null &&
                                                                              GameObject.Find("forest_path(Clone)") == null &&
                                                                                GameObject.Find("city_path(Clone)") == null))) {
            comp17 = true;
            wave18 = true;
        } else if (comp17 == true && comp18 == false && (time == 5500 || (GameObject.Find("forestb02_enemy(Clone)") == null &&
                                                                           GameObject.Find("forest02_enemy(Clone)") == null &&
                                                                           GameObject.Find("waterb02_enemy(Clone)") == null &&
                                                                            GameObject.Find("water02_enemy(Clone)") == null &&
                                                                              GameObject.Find("forest_path(Clone)") == null &&
                                                                               GameObject.Find("water_path(Clone)") == null))) {
            comp18 = true;
            wave19 = true;
        } else if (comp18 == true && comp19 == false && (time == 5500 || (GameObject.Find("forest02_enemy(Clone)") == null &&
                                                                           GameObject.Find("water02_enemy(Clone)") == null &&
                                                                            GameObject.Find("city02_enemy(Clone)") == null &&
                                                                             GameObject.Find("forest_path(Clone)") == null &&
                                                                              GameObject.Find("water_path(Clone)") == null &&
                                                                               GameObject.Find("city_path(Clone)") == null))) {
            comp19 = true;
            wave20 = true;
        } else if (comp19 == true && comp20 == false && (time == 5500 || (GameObject.Find("forestb02_enemy(Clone)") == null &&
                                                                           GameObject.Find("waterb02_enemy(Clone)") == null &&
                                                                            GameObject.Find("cityb02_enemy(Clone)") == null &&
                                                                             GameObject.Find("forestb_path(Clone)") == null &&
                                                                              GameObject.Find("waterb_path(Clone)") == null &&
                                                                               GameObject.Find("cityb_path(Clone)") == null))) {
            comp20 = true;
            waveB4 = true;
        } else if (comp20 == true && compB4 == false && (time == 10500 || GameObject.Find("space_boss(Clone)") == null)) {
            compB4 = true;
        }

		if (Time.timeScale != 0) {
		    time++;
        	overall++;
        }
	}
}
