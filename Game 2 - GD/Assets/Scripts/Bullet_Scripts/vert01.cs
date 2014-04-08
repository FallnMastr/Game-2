using UnityEngine;
using System.Collections;

public class vert01 : MonoBehaviour {

	int count = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime * 5);

        if (Time.timeScale != 0) {
		    count++;
        }
		
		if (count > 150) {
			suicide ();
		}
	}

	void suicide(){
		UnityEngine.Object.Destroy (gameObject);
	}

	void OnTriggerEnter(Collider c){
//		Debug.Log ("bullet impact");
	}

}
