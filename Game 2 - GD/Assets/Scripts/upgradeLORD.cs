using UnityEngine;
using System.Collections;

public class upgradeLORD : MonoBehaviour {

	public static bool getWater = false;
	public static bool getFire = false;
	public static bool getEarth = false;

	public static int total = 0;

	public static bool coop = false;

	public static float p1score = 0;
	public static float p2score = 0;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	// Use this for initialization
	void Start () {
        
	}

	void Update(){
		if (Application.loadedLevel == 0) {
			Destroy(this.gameObject);
		}
		if(Input.GetKeyDown(KeyCode.Minus)){
			player_behavior.lives++;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
            if (Time.timeScale == 1) {
                Time.timeScale = 0;
            } else {
                Time.timeScale = 1;
            }
        }

        if (Input.GetKeyDown (KeyCode.Q)) {
            Application.Quit();
            Debug.Log("quit");
		}
	}

    /*public void setTotal(int score1, int score2) {
        p1score += score1;
        p2score += score2;
    }

    public float getTotalP1() {
        return p1score;
    }

    public float getTotalP2() {
        return p2score;
    }*/
}
