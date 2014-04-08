using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System;

public class game_end_script : MonoBehaviour {

	public bool haveHS = false;
	public string name = "Enter name";

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
		if(stage == 1){
			float alpha = (float)(frontQuad.renderer.material.color.a - .01);
			frontQuad.renderer.material.SetColor("_Color", new Color(0,0,0,alpha));
			if(alpha <= 0){
				stage = 2;
			}
		}
		else if(stage == 2){
			if(Input.anyKey){
				Application.LoadLevel(Application.loadedLevel+1);
			}
		}
	}

	void highScoreCheck(){
		StreamReader read = new StreamReader (Application.dataPath + "/highScore.txt");
		string writeString = "";
		int line_count = 0;
		string line = read.ReadLine ();
		if (line == null) {
			//no scores
		}
		while (line != null) {
			line_count++;

			string[] arr = line.Split(new char [] {' '});
			int val = 0;
			Int32.TryParse(arr[1], out val);
			if(upgradeLORD.p1score > val){
				haveHS= true;

				writeString += name +" "+upgradeLORD.p1score + "\\n";
			}
			else{
				writeString += line + "\\n";
			}


			if(line_count == 5){
				break;
			}

			line = read.ReadLine();
		}

		read.Close ();
	}

	void OnGUI(){

	//	name = GUI.TextField(new Rect(10, 10, 200, 20), name, 25);

	}
}
