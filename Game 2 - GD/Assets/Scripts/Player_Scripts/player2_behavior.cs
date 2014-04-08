using UnityEngine;
using System.Collections;

public class player2_behavior : player_behavior {


	// Use this for initialization
	void Start () {
        score = upgradeLORD.p2score;

		u = KeyCode.UpArrow;
		l = KeyCode.LeftArrow;
		r = KeyCode.RightArrow;
		d = KeyCode.DownArrow;
		
		f = KeyCode.L;
		self_index = 1;

		shield = shield_max;
		health = health_max;
		self_index = 0;
		
		ship = Resources.Load<Sprite>("ship2");
		damage = Resources.Load<Sprite>("ship-red");
		
		shield_object = (GameObject)Instantiate(Resources.Load("shield_prefab2"), gameObject.transform.position, gameObject.transform.rotation);
		shield_object.SendMessage("setOwner", "player2");

		respawnPoint = new Vector3 (1,-2,0);
		cycleElement ();
	}

}
