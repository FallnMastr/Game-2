using UnityEngine;
using System.Collections;

public class quad1_script : MonoBehaviour {
	
	public GameObject frontQuad;
	public int startPoint;
	int count = 0;
	int stage = 1;
	
	bool run = true;
	
	
	int total = 0;
	
	// Use this for initialization
	void Start () {
		frontQuad = GameObject.FindWithTag ("Fader");
		
		startPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale != 0) {
                total++;
            }
		
		if(stage == 1){
			if (Time.timeScale != 0) {
                count++;
            }

			if(count >= startPoint){
				gameObject.transform.Translate(new Vector3(0,0,-2));
				count = 0;
				stage = 2;
			}
		} else if(stage == 2) {
			float alpha = (float)(frontQuad.renderer.material.color.a - .01);
			frontQuad.renderer.material.SetColor("_Color", new Color(0,0,0,alpha));
			if(alpha <= 0){
				stage = 3;
			}
		} else if(stage == 3) {
			int checkpoint = 200;

            if (Time.timeScale != 0) {
                count++;
            }

			if(count >= checkpoint){
				float alpha = (float)(frontQuad.renderer.material.color.a + .01);
				frontQuad.renderer.material.SetColor("_Color", new Color(0,0,0,alpha));
				if(alpha >= 1){
					stage = 4;
				}
			}
		} else if(stage == 4) {
			gameObject.transform.Translate(new Vector3(0,0,2));
			stage = 5;
		} else {
			if(total >= 1250){
				Application.LoadLevel(2);
			}
		}
	}
}
