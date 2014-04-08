using UnityEngine;
using System.Collections;

public class water_trans_script : MonoBehaviour {
	
	public GameObject frontQuad;
	public int startPoint;
	int count = 0;
	int stage = 1;
	
	bool run = true;
	
	Texture fail;
	
	int total = 0;
	
	// Use this for initialization
	void Start () {
		frontQuad = GameObject.FindWithTag ("Fader");
		
		fail = (Texture)Resources.Load("no relic ending");
		Debug.Log (fail);
		//if player has waterRelic
		if(!upgradeLORD.getWater){
			gameObject.renderer.material.SetTexture ("_MainTex",fail);
		}
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
		} else if(stage == 2) {
			int checkpoint = 150;
			
            if (Time.timeScale != 0) {
                count++;
            }
            
			if(count >= checkpoint){
				Application.LoadLevel(Application.loadedLevel+1);
			}
		}
	}
}
