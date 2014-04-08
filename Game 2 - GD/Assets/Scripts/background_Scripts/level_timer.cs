using UnityEngine;
using System.Collections;

public class level_timer : MonoBehaviour {

	public static float timer = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
	}
}
