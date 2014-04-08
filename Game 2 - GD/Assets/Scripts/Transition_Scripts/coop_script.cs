using UnityEngine;
using System.Collections;

public class coop_script : MonoBehaviour {

	
	public GameObject frontQuad;
	public int startPoint;
	int stage = 1;
	
	int total = 0;
	
	// Use this for initialization
	void Start () {
		frontQuad = GameObject.FindWithTag ("Fader");		
		startPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(stage == 1){
			float alpha = (float)(frontQuad.renderer.material.color.a - .01);
			frontQuad.renderer.material.SetColor("_Color", new Color(0,0,0,alpha));
			if(alpha <= 0){
				stage = 2;
			}
		}
		else if(stage == 2){
			
			bool one = Input.GetKeyDown (KeyCode.Alpha1);
			bool two = Input.GetKeyDown (KeyCode.Alpha2);
			
			if(two){
				upgradeLORD.coop = true;
				Debug.Log("coop");
			}
			
			if(two || one){
				Application.LoadLevel(1);
			}
		}
	}
}
