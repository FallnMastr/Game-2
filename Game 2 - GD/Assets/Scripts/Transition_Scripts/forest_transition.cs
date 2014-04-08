using UnityEngine;
using System.Collections;

public class forest_transition : MonoBehaviour {
	
	public GameObject frontQuad;
	public int startPoint;
	int count = 0;
	int stage = 1;
	
	bool run = true;
	
	Texture failE;
	Texture failEW;
	Texture failEF;
	Texture failOne;
	Texture failAll;

	Texture NEF;
	Texture NEWF;
	Texture NEW;
	
	int total = 0;
	
	// Use this for initialization
	void Start () {
		frontQuad = GameObject.FindWithTag ("Fader");

		NEF = (Texture)Resources.Load("only fire ending");
		NEW = (Texture)Resources.Load("only water endeing");
		NEWF = (Texture)Resources.Load("fire-water relic ending");

		failE = (Texture)Resources.Load("earth relic ending4");
		failEW = (Texture)Resources.Load ("earth relic ending2");
		failEF = (Texture)Resources.Load ("earth relic ending3");
		failOne = (Texture)Resources.Load("no relic ending2");
		failAll = (Texture)Resources.Load("no relic ending");
		
		//if player has 2 Relic
		if(upgradeLORD.getEarth && upgradeLORD.getWater && !upgradeLORD.getFire){
			gameObject.renderer.material.SetTexture ("_MainTex",failEW);
		} else if(upgradeLORD.getEarth && upgradeLORD.getFire && !upgradeLORD.getWater) {
			gameObject.renderer.material.SetTexture ("_MainTex",failEF);
		} else if(upgradeLORD.getEarth && !upgradeLORD.getFire && !upgradeLORD.getWater) {
			gameObject.renderer.material.SetTexture ("_MainTex",failE);
		} else if(!upgradeLORD.getEarth && upgradeLORD.getFire && upgradeLORD.getWater) {
			gameObject.renderer.material.SetTexture ("_MainTex",NEWF);
		} else if(!upgradeLORD.getEarth && upgradeLORD.getFire && !upgradeLORD.getWater) {
			gameObject.renderer.material.SetTexture ("_MainTex",NEF);
		} else if(!upgradeLORD.getEarth && !upgradeLORD.getFire && upgradeLORD.getWater) {
			gameObject.renderer.material.SetTexture ("_MainTex",NEW);
		} else if(!upgradeLORD.getEarth && !upgradeLORD.getFire && !upgradeLORD.getWater) {
			gameObject.renderer.material.SetTexture ("_MainTex",failAll);
		} else if(!upgradeLORD.getEarth){
			gameObject.renderer.material.SetTexture ("_MainTex",failOne);
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
