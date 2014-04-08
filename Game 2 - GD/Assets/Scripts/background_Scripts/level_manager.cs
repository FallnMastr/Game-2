using UnityEngine;
using System.Collections;

public class level_manager : MonoBehaviour {

	public static bool bossHasRelic = false;
	public static bool levelFinished = false;

	public static bool bossRun = false;

	public static bool loaded = true;

	GameObject p2;
	
	// Use this for initialization
	void Start () {
		bossHasRelic = false;
		levelFinished = false;
		bossRun = false;

		if (upgradeLORD.coop == true) {
			Debug.Log("player 2 loading...");
			p2 = (GameObject)Instantiate(Resources.Load("player2"), new Vector3(1,-5,0), gameObject.transform.rotation);
			Debug.Log("done");
		}
	}

	void Update(){
		if (upgradeLORD.coop == true && p2 == null) {
			p2 = (GameObject)Instantiate(Resources.Load("player2"), new Vector3(1,-5,0), gameObject.transform.rotation);
		}

	}

}
