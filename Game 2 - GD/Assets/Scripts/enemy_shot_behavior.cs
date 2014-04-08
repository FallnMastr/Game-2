using UnityEngine;
using System.Collections;

public class enemy_shot_behavior : MonoBehaviour {

	int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(Vector3.down * Time.deltaTime * 5);
		
		count++;
		
		if (count > 200) {
			suicide ();
		}
	}
	
	void suicide(){
		Object.Destroy (gameObject);
	}
}
