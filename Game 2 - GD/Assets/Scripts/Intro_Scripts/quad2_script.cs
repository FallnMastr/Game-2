using UnityEngine;
using System.Collections;

public class quad2_script : quad1_script{

	// Use this for initialization
	void Start () {
		frontQuad = GameObject.FindWithTag ("Fader");
		
		startPoint = 453;
	}

}
