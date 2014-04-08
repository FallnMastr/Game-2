using UnityEngine;
using System.Collections;
using System;

public class forest_level : MonoBehaviour {
	public AudioSource forest_dl;
    public AudioSource boss;

	int time = 0;
    int plus = 0;
    int overall = 0;
    bool wave01 =  true, wave02 = false, wave03 = false,
         wave04 = false, wave05 = false, wave06 = false,
         wave07 = false, wave08 = false, wave09 = false,
         wave10 = false, wave11 = false, wave12 = false,
         wave13 = false, wave14 = false, wave15 = false,
          waveB = false;
    bool comp01 = false, comp02 = false, comp03 = false,
         comp04 = false, comp05 = false, comp06 = false,
         comp07 = false, comp08 = false, comp09 = false,
         comp10 = false, comp11 = false, comp12 = false,
         comp13 = false, comp14 = false, comp15 = false,
          compB = false;

    /*bool comp01 = true, comp02 = true, comp03 = true,
         comp04 = true, comp05 = true, comp06 = true,
         comp07 = true, comp08 = true, comp09 = true,
         comp10 = true, comp11 = true, comp12 = true,
         comp13 = true, comp14 = true, comp15 = true,
          compB = false;*/

    public KeyCode p;

	// Use this for initialization
	void Start () {
        p = KeyCode.P;
		forest_dl = (AudioSource)gameObject.AddComponent ("AudioSource");
		AudioClip myAudioClip1;
		myAudioClip1 = (AudioClip)Resources.Load ("tunes/forest_dl");
		forest_dl.clip = myAudioClip1;
		forest_dl.volume = 0.05f;
		forest_dl.Play ();
		forest_dl.loop = true;

        boss = (AudioSource)gameObject.AddComponent("AudioSource");
        AudioClip myAudioClipb;
        myAudioClipb = (AudioClip)Resources.Load("tunes/Muzzy - Endgame (normal)");
        boss.clip = myAudioClipb;
        boss.volume = 0.04f;
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
            GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
			go1.transform.Translate(-5, 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
			go2.transform.Translate(Convert.ToSingle(-3.57), 3, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
			go3.transform.Translate(Convert.ToSingle(-2.14), 2, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
			go4.transform.Translate(Convert.ToSingle(-0.71), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
			go5.transform.Translate(Convert.ToSingle(0.71), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 3, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 2, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go8.transform.Translate(5, 0, 0);

            wave01 = false;
            time = 0;
		} else if (wave02) {
            Debug.Log("wave 2");
			// spawn wave 2
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
			go1.transform.Translate(-5, 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 2, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.71), 3, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.71), 2, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 2, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
			go8.transform.Translate(5, 1, 0);

            wave02 = false;
            time = 0;
		} else if (wave03) {
            Debug.Log("wave 3");
			// spawn wave 3
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 3, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.71), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.71), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 2, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go8.transform.Translate(5, 1, 0);
            GameObject go9 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go9.transform.Translate(Convert.ToSingle(-4.29), 3, 0);
            GameObject go0 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go0.transform.Translate(Convert.ToSingle(4.29), 2, 0);

            wave03 = false;
            time = 0;
		} else if (wave04) {
            Debug.Log("wave 4");
			// spawn wave 4
            GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 2, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go6.transform.Translate(5, 1, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go7.transform.Translate(Convert.ToSingle(-4.29), 3, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go8.transform.Translate(Convert.ToSingle(-2.86), 1, 0);
            GameObject go9 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go9.transform.Translate(Convert.ToSingle(2.86), 2, 0);
            GameObject go0 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go0.transform.Translate(Convert.ToSingle(4.29), 0, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("w4_path"));
            go01.transform.Translate(0, 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("w4_path"));
            go02.transform.Translate(0, 2, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("w4_path"));
            go03.transform.Translate(0, 4, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("w4_path"));
            go04.transform.Translate(0, 6, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("w4_path"));
            go05.transform.Translate(0, 8, 0);

            wave04 = false;
            time = 0;
		} else if (wave05) {
            Debug.Log("wave 5");
			// spawn wave 5
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 2, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 2, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 3, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(5, 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go7.transform.Translate(Convert.ToSingle(-4.29), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go8.transform.Translate(Convert.ToSingle(-2.86), 1, 0);
            GameObject go9 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go9.transform.Translate(Convert.ToSingle(2.86), 2, 0);
            GameObject go0 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go0.transform.Translate(Convert.ToSingle(4.29), 1, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("w5_path"));
            go01.transform.Translate(0, 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("w5_path"));
            go02.transform.Translate(0, 2, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("w5_path"));
            go03.transform.Translate(0, 4, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("w5_path"));
            go04.transform.Translate(0, 6, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("w5_path"));
            go05.transform.Translate(0, 8, 0);

            wave05 = false;
            time = 0;
        } else if (wave06) {
            Debug.Log("wave 6");
            // spawn wave 6
            GameObject go1 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go1.transform.Translate(-5, 2, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 3, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 2, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 3, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go6.transform.Translate(5, 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go7.transform.Translate(Convert.ToSingle(-4.29), 3, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go8.transform.Translate(Convert.ToSingle(4.29), 1, 0);
            GameObject go9 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go9.transform.Translate(0, 0, 0);

            wave06 = false;
            time = 0;
        } else if (wave07) {
            Debug.Log("wave 7");
            // spawn wave 7
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 3, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 3, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.71), 1, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.71), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 0, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("vert_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 2, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go8.transform.Translate(5, 2, 0);
            GameObject go9 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go9.transform.Translate(0, 3, 0);

            wave07 = false;
            time = 0;
        } else if (wave08) {
            Debug.Log("wave 8");
            // spawn wave 8
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 0, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 2, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.71), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.71), 3, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 1, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 2, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go8.transform.Translate(5, 2, 0);

            wave08 = false;
            time = 0;
        } else if (wave09) {
            Debug.Log("wave 9");
            // spawn wave 9
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.71), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.71), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 2, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 2, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go8.transform.Translate(5, 1, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 2, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go03.transform.Translate(Convert.ToSingle(2.86), 1, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go04.transform.Translate(Convert.ToSingle(4.29), 0, 0);

            wave09 = false;
            time = 0;
        } else if (wave10) {
            Debug.Log("wave 10");
            // spawn wave 10
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 3, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 2, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 3, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(5, 2, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go7.transform.Translate(0, 3, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 2, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 0, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go03.transform.Translate(Convert.ToSingle(-1.43), 1, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go04.transform.Translate(0, 3, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("vert02_enemy"));
            go05.transform.Translate(Convert.ToSingle(1.43), 0, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go06.transform.Translate(Convert.ToSingle(2.86), 1, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(Convert.ToSingle(4.29), 2, 0);

            wave10 = false;
            time = 0;
        } else if (wave11) {
            Debug.Log("wave 11");
            // spawn wave 11
            GameObject go1 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go1.transform.Translate(-5, 3, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 3, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 0, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.71), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.71), 2, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 3, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 2, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go8.transform.Translate(5, 2, 0);
            GameObject go9 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go9.transform.Translate(0, 0, 0);

            wave11 = false;
            time = 0;
        } else if (wave12) {
            Debug.Log("wave 12");
            // spawn wave 12
            GameObject go1 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go1.transform.Translate(-5, 3, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("forestb_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("forestb_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go4.transform.Translate(Convert.ToSingle(-0.71), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go5.transform.Translate(Convert.ToSingle(0.71), 1, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("forestb_enemy"));
            go6.transform.Translate(Convert.ToSingle(2.14), 2, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forestb_enemy"));
            go7.transform.Translate(Convert.ToSingle(3.57), 0, 0);
            GameObject go8 = (GameObject)Instantiate(Resources.Load("forest_enemy"));
            go8.transform.Translate(5, 3, 0);

            wave12 = false;
            time = 0;
        } else if (wave13) {
            Debug.Log("wave 13");
            // spawn wave 13
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 2, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 1, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 3, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 0, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(5, 2, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forestb_path"));
            go7.transform.Translate(0, 3, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 1, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 3, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go03.transform.Translate(Convert.ToSingle(-1.43), 0, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go04.transform.Translate(0, 1, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("forest02_enemy"));
            go05.transform.Translate(Convert.ToSingle(1.43), 2, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go06.transform.Translate(Convert.ToSingle(2.86), 0, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(Convert.ToSingle(4.29), 2, 0);

            wave13 = false;
            time = 0;
        } else if (wave14) {
            Debug.Log("wave 14");
            // spawn wave 14
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 0, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(-2.14), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(Convert.ToSingle(2.14), 0, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go5.transform.Translate(Convert.ToSingle(3.57), 2, 0);
            GameObject go6 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go6.transform.Translate(5, 2, 0);
            GameObject go7 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go7.transform.Translate(0, 3, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 3, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 2, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go03.transform.Translate(Convert.ToSingle(-1.43), 0, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go04.transform.Translate(0, 3, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go05.transform.Translate(Convert.ToSingle(1.43), 2, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go06.transform.Translate(Convert.ToSingle(2.86), 1, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(Convert.ToSingle(4.29), 0, 0);

            wave14 = false;
            time = 0;
        } else if (wave15) {
            Debug.Log("wave 15");
            // spawn wave 15
            GameObject go1 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go1.transform.Translate(-5, 1, 0);
            GameObject go2 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go2.transform.Translate(Convert.ToSingle(-3.57), 3, 0);
            GameObject go3 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go3.transform.Translate(Convert.ToSingle(3.57), 1, 0);
            GameObject go4 = (GameObject)Instantiate(Resources.Load("towards_enemy"));
            go4.transform.Translate(5, 2, 0);
            GameObject go5 = (GameObject)Instantiate(Resources.Load("forest_path"));
            go5.transform.Translate(0, 3, 0);

            GameObject go01 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go01.transform.Translate(Convert.ToSingle(-4.29), 0, 0);
            GameObject go02 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go02.transform.Translate(Convert.ToSingle(-2.86), 1, 0);
            GameObject go03 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go03.transform.Translate(Convert.ToSingle(-1.43), 3, 0);
            GameObject go04 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go04.transform.Translate(0, 2, 0);
            GameObject go05 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go05.transform.Translate(Convert.ToSingle(1.43), 0, 0);
            GameObject go06 = (GameObject)Instantiate(Resources.Load("forestb02_enemy"));
            go06.transform.Translate(Convert.ToSingle(2.86), 1, 0);
            GameObject go07 = (GameObject)Instantiate(Resources.Load("towards02_enemy"));
            go07.transform.Translate(Convert.ToSingle(4.29), 3, 0);

            wave15 = false;
            time = 0;
		} else if (waveB) {
            Debug.Log("boss");
			// spawn boss
            forest_dl.Stop();
            boss.Play();
            boss.loop = true;

            GameObject goB = (GameObject)Instantiate(Resources.Load("forest_boss"));
			goB.transform.Translate(0, 0, .01f);
            waveB = false;
            time = 0;
		}

        // switching waves
        if (comp01 == false && (time == 5500 || GameObject.Find("vert_enemy(Clone)") == null)) {
            comp01 = true;
            wave02 = true;
        } else if (comp01 == true && comp02 == false && (time == 5500 || (GameObject.Find("towards_enemy(Clone)") == null &&
                                                                             GameObject.Find("vert_enemy(Clone)") == null))) {
            comp02 = true;
            wave03 = true;
        } else if (comp02 == true && comp03 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                               GameObject.Find("vert_enemy(Clone)") == null))) {
            comp03 = true;
            wave04 = true;
        } else if (comp03 == true && comp04 == false && (time == 5500 || (GameObject.Find("vert02_enemy(Clone)") == null &&
                                                                            GameObject.Find("vert_enemy(Clone)") == null &&
                                                                               GameObject.Find("w4_path(Clone)") == null))) {
            comp04 = true;
            wave05 = true;
        } else if (comp04 == true && comp05 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                                  GameObject.Find("w5_path(Clone)") == null))) {
            comp05 = true;
            wave06 = true;
        } else if (comp05 == true && comp06 == false && (time == 5500 || (GameObject.Find("vert02_enemy(Clone)") == null &&
                                                                          GameObject.Find("forest_enemy(Clone)") == null &&
                                                                            GameObject.Find("vert_enemy(Clone)") == null))) {
            comp06 = true;
            wave07 = true;
        } else if (comp06 == true && comp07 == false && (time == 5500 || (GameObject.Find("forest02_enemy(Clone)") == null &&
                                                                           GameObject.Find("towards_enemy(Clone)") == null &&
                                                                            GameObject.Find("forest_enemy(Clone)") == null &&
                                                                              GameObject.Find("vert_enemy(Clone)") == null))) {
            comp07 = true;
            wave08 = true;
        } else if (comp07 == true && comp08 == false && (time == 5500 || (GameObject.Find("towards_enemy(Clone)") == null &&
                                                                           GameObject.Find("forest_enemy(Clone)") == null))) {
            comp08 = true;
            wave09 = true;
        } else if (comp08 == true && comp09 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                             GameObject.Find("forest_enemy(Clone)") == null))) {
            comp09 = true;
            wave10 = true;
        } else if (comp09 == true && comp10 == false && (time == 5500 || (GameObject.Find("towards02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                             GameObject.Find("vert02_enemy(Clone)") == null &&
                                                                              GameObject.Find("forest_path(Clone)") == null))) {
            comp10 = true;
            wave11 = true;
        } else if (comp10 == true && comp11 == false && (time == 5500 || (GameObject.Find("forestb02_enemy(Clone)") == null &&
                                                                            GameObject.Find("towards_enemy(Clone)") == null &&
                                                                             GameObject.Find("forest_enemy(Clone)") == null))) {
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
             waveB = true;
        } else if (comp15 == true && compB == false && (time == 10500 || GameObject.Find("forest_boss(Clone)") == null)) {
            overall -= time;
             compB = true;
        }

		if (Time.timeScale != 0) {
		    time++;
		    if(!level_manager.levelFinished){
        	    overall++;
		    }
        }
	}

    public int timeBonus() {
        int score = 82500 - overall;
        
        return score;
    }
}
