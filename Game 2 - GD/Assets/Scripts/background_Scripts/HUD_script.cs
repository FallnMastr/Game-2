using UnityEngine;
using System.Collections;
using System;

public class HUD_script : MonoBehaviour {

	private GUIStyle textstyle = new GUIStyle();
	public float time = boss_timer.seconds;

    water_level w;
    city_level c;
    forest_level f;
    space_level x;

	Texture draw1;
	Texture draw2; 

	Texture element;
	Texture element2;

	Texture fire;
	Texture water;
	Texture earth;

	Texture shield;
	Texture health;
	Texture damage;
	Texture black;

	Texture lives;

	Texture relic;

	int count = 0;
	bool set_health = false;

	int health_metric = 0;
	int h = 0;
	// Use this for initialization
	void Start () {
		w = (water_level)FindObjectOfType(typeof(water_level));
		c = (city_level)FindObjectOfType(typeof(city_level));
		f = (forest_level)FindObjectOfType(typeof(forest_level));
		x = (space_level)FindObjectOfType(typeof(space_level));


		draw1 = (Texture)Resources.Load("playerShotTemp");
		draw2 = (Texture)Resources.Load("enemyTemp");

		black = (Texture)Resources.Load("background");
		shield = (Texture)Resources.Load("shield");
		health = (Texture)Resources.Load("health");
		damage = (Texture)Resources.Load("damage");

		lives = (Texture)Resources.Load("heart");

		fire = (Texture)Resources.Load("Fire Element");
		water = (Texture)Resources.Load("Water Element");
		earth = (Texture)Resources.Load("Earth Element");

		level_manager.levelFinished = false;

	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find("player");
		GameObject player2 = GameObject.Find("player2(Clone)");

		if (player.GetComponent<player_behavior>().getElement().Equals ("water")) {
			element = water;
		}
		else if (player.GetComponent<player_behavior>().getElement().Equals ("fire")) {
			element = fire;
		}
		else if (player.GetComponent<player_behavior>().getElement().Equals ("earth")) {
			element = earth;
		}

		if(player2 != null){
			if (player2.GetComponent<player2_behavior>().getElement().Equals ("water")) {
				element2 = water;
			}
			else if (player2.GetComponent<player2_behavior>().getElement().Equals ("fire")) {
				element2 = fire;
			}
			else if (player2.GetComponent<player2_behavior>().getElement().Equals ("earth")) {
				element2 = earth;
			}
		}
	}

	void OnGUI () {


	//Boss timer and health
		GameObject b = GameObject.FindWithTag ("Boss");
		if(b != null){

			if(b.gameObject.ToString().Contains("water")){
				water_boss boss = (water_boss)FindObjectOfType(typeof(water_boss));
				if(set_health == false){
					health_metric = boss.health;
					set_health = true;
				}
				h = boss.health;
			}
			if(b.gameObject.ToString().Contains("city")){
				city_boss boss = (city_boss)FindObjectOfType(typeof(city_boss));
				if(set_health == false){
					health_metric = boss.health;
					set_health = true;
				}
				h = boss.health;
			}
			if(b.gameObject.ToString().Contains("forest")){
				forest_boss boss = (forest_boss)FindObjectOfType(typeof(forest_boss));
				if(set_health == false){
					health_metric = boss.health;
					set_health = true;
				}
				h = boss.health;
			}
			if(b.gameObject.ToString().Contains("space")){
				space_boss boss = (space_boss)FindObjectOfType(typeof(space_boss));
				if(set_health == false){
					health_metric = boss.health;
					set_health = true;
				}
				h = boss.health;
			}

			Debug.Log(health_metric);
			if(health_metric == 200){
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 300),10,600,30),damage);
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 300),10,h * 3,30),health);
			}
			else if(health_metric == 300){
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 300),10,600,30),damage);
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 300),10,h * 2,30),health);
			}
			else if(health_metric == 500){
				Debug.Log(h);
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 250),10,500,30),damage);
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 250),10,h,30),health);
			}
			else if(health_metric == 600){

				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 300),10,600,30),damage);
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 300),10,h,30),health);
			}
			else if(health_metric == 800){
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 200),10,400,30),damage);
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 200),10,h/2,30),health);
			}
			else if(health_metric == 1200){
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 300),10,600,30),damage);
				GUI.DrawTexture(new Rect((float)(Screen.width/2 - 300),10,h/2,30),health);
			}



			if(level_manager.bossHasRelic && Application.loadedLevel != 8){ //timer
				if(time > 0){
					time = time - Time.deltaTime;
				}

				if(time <= 0 && level_manager.bossHasRelic){
					level_manager.bossRun = true;
				}
				else{
					textstyle.fontStyle = FontStyle.Bold;
					if (time < (boss_timer.seconds/5)) {
						textstyle.normal.textColor = UnityEngine.Color.red;		
					}
					else {
						textstyle.normal.textColor = UnityEngine.Color.yellow;		
					}
					string text = string.Format ("Time Until Boss Escapes: {0:00}:{1:00}", Math.Floor(time/60), Math.Floor(time%60));
					GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.93*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), text, textstyle);
				}
			}
		}
		else{
			set_health = false;
		}

	//Player 1 stuff
		GameObject play = GameObject.Find("player");

		GUI.Box(new Rect(10,10,100,90), "Element");
		if(player_behavior.hasRelic && element != null){
			GUI.DrawTexture(new Rect(35,30,50,70),element);
		}

		GUI.TextField (new Rect(5,110,150,20),"Player Score: "+play.GetComponent<player_behavior>().getScore().ToString());

		//life
		GUI.DrawTexture(new Rect(18,138,34,304),black);
		GUI.DrawTexture(new Rect(20,140,30,300),damage);
		GUI.DrawTexture(new Rect(20,140,30,play.GetComponent<player_behavior>().getHealth() * 100),health);

		GameObject s = GameObject.Find("shield_prefab(Clone)");

		if (s.GetComponent<shield_script>().getOn()) {
			GUI.DrawTexture (new Rect (20, 140, 30, play.GetComponent<player_behavior>().getShield() * 50), shield);
		}


		//lives
		if (player_behavior.lives >= 2) {
			for(int i = 0; i < player_behavior.lives-1;i++){
				GUI.DrawTexture (new Rect (60, 140+(35*i), 30, 30), lives);
			}
		}

	//Player 2 stuff
		GameObject play2 = GameObject.Find("player2(Clone)");
		if(play2 != null){

			GUI.Box(new Rect(Screen.width-110,10,100,90), "Element");
			if(element != null){
				GUI.DrawTexture(new Rect(Screen.width-85,30,50,70),element2);
			}
			
			GUI.TextField (new Rect(Screen.width-155,110,150,20),"Player Score: "+play2.GetComponent<player2_behavior>().getScore().ToString());

			GUI.DrawTexture(new Rect(Screen.width - 52,138,34,304),black);
			GUI.DrawTexture(new Rect(Screen.width - 50,140,30,300),damage);
			GUI.DrawTexture(new Rect(Screen.width - 50,140,30,play2.GetComponent<player2_behavior>().getHealth() * 100),health);

			s = GameObject.Find("shield_prefab2(Clone)");

			if (s.GetComponent<shield_script>().getOn()) {
				GUI.DrawTexture (new Rect (Screen.width - 50, 140, 30, play2.GetComponent<player2_behavior>().getShield() * 50), shield);
			}

			if (player_behavior.lives >= 2) {
				for(int i = 0; i < player_behavior.lives-1;i++){
					GUI.DrawTexture (new Rect (Screen.width - 90, 140+(35*i), 30, 30), lives);
				}
			}
		}


	//End of level stuff
		if(level_manager.levelFinished == true){
            textstyle.normal.textColor = UnityEngine.Color.white;
            textstyle.alignment = TextAnchor.MiddleCenter;
            textstyle.fontSize = 32;
			count++;

            float timeBonus = 0;

            // Which timer should be used
            if (Application.loadedLevel == 2) {
                timeBonus = w.timeBonus();
            } else if (Application.loadedLevel == 4) {
                timeBonus = c.timeBonus();
            } else if (Application.loadedLevel == 6) {
                timeBonus = f.timeBonus();
            } else if (Application.loadedLevel == 8) {
				timeBonus = x.timeBonus();
            }

			float relicPoints = (player_behavior.hasRelic == true) ? 50 : 0;
			string relic = string.Format ("Relic Points: {0}", relicPoints);
			float bossPoints = (player_behavior.hasRelic == true) ? time : boss_timer.seconds;
			string boss = string.Format ("Boss Points: {0}", bossPoints);
            string bonus = string.Format("Time Bonus: {0}", timeBonus);
			string player = string.Format ("Player Score: {0}", play.GetComponent<player_behavior>().getScore());
			string total = string.Format ("Player 1 Total Score: {0}", play.GetComponent<player_behavior>().getScore() + relicPoints + bossPoints + timeBonus);
			float totalPoints = play.GetComponent<player_behavior>().getScore() + relicPoints + bossPoints + timeBonus;

			float relicPoints2;
			string relic2 = "";
			float bossPoints2;
			string boss2 = "";
			float timeBonus2;
			string bonus2 = "";
			string player2 = "";
			string total2 = "";
			float totalPoints2 = 0;


			if(play2 != null){
				relicPoints2 = (player_behavior.hasRelic == true) ? 50 : 0;
				relic2 = string.Format ("Relic Points: {0}", relicPoints2);
				bossPoints2 = (player_behavior.hasRelic == true) ? time : boss_timer.seconds;
				boss2 = string.Format ("Boss Points: {0}", bossPoints2);
                timeBonus2 = timeBonus;
				bonus2 = string.Format("Time Bonus: {0}", timeBonus2);
				player2 = string.Format ("Player Score: {0}", play2.GetComponent<player2_behavior>().getScore());
				total2 = string.Format ("Player 2 Total Score: {0}", play2.GetComponent<player2_behavior>().getScore() + relicPoints2 + bossPoints + timeBonus2);
				totalPoints2 = play2.GetComponent<player2_behavior>().getScore() + relicPoints2 + bossPoints2 + timeBonus2;
			}


			if(count >= 50 && count < 700){
                drawOutline(new Rect(0, (float)0.2 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), player, textstyle, Color.black, Color.white);
                //GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.3*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), player, textstyle);
			}
			if(count >= 150 && count < 700){
                drawOutline(new Rect(0, (float)0.3 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), relic, textstyle, Color.black, Color.white);
                //GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.4*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), relic, textstyle);
			}
			if(count >= 250 && count < 700){
                drawOutline(new Rect(0, (float)0.4 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), boss, textstyle, Color.black, Color.white);
                //GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.5*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), boss, textstyle);
			}
			if (count >= 350 && count < 700) {
                drawOutline(new Rect(0, (float)0.5 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), bonus, textstyle, Color.black, Color.white);
            }
			if(count >= 450 && count < 700){
                drawOutline(new Rect(0, (float)0.7 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), total, textstyle, Color.black, Color.white);
                //GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.7*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), total, textstyle);
			}

			if(play2 == null){
				if(count >= 700){
					upgradeLORD.p1score = totalPoints;
					Application.LoadLevel(Application.loadedLevel+1);
				}
			}
			else{
				if(count >= 700){
					drawOutline(new Rect(0, (float)0.2 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), player2, textstyle, Color.black, Color.white);
					//GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.3*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), player, textstyle);
				}
				if(count >= 800){
					drawOutline(new Rect(0, (float)0.3 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), relic2, textstyle, Color.black, Color.white);
					//GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.4*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), relic, textstyle);
				}
				if(count >= 900){
					drawOutline(new Rect(0, (float)0.4 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), boss2, textstyle, Color.black, Color.white);
					//GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.5*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), boss, textstyle);
				}
				if (count >= 1000) {
					drawOutline(new Rect(0, (float)0.5 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), bonus2, textstyle, Color.black, Color.white);
				}
				if(count >= 1100){
					drawOutline(new Rect(0, (float)0.7 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), total2, textstyle, Color.black, Color.white);
					//GUI.Label(new Rect((float)0.4*UnityEngine.Screen.width, (float)0.7*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), total, textstyle);
				}
				if(count >= 1350){
					upgradeLORD.p1score = totalPoints;
					upgradeLORD.p2score = totalPoints2;
					Application.LoadLevel(Application.loadedLevel+1);
				}
			}

		}
	}

	void loadRelic(){
		if(Application.loadedLevel == 2){
			relic = (Texture)Resources.Load("water relic2");
		}
		else if(Application.loadedLevel == 6){
			relic = (Texture)Resources.Load("earth relic2");
		}
		else if(Application.loadedLevel == 4){
			relic = (Texture)Resources.Load("fire relic2");
		}
	}

    void drawOutline(Rect position, String text, GUIStyle style, Color outColor, Color inColor) {
        var backupStyle = style;
        style.normal.textColor = outColor;
        position.x--;
        GUI.Label(position, text, style);
        position.x +=2;
        GUI.Label(position, text, style);
        position.x--;
        position.y--;
        GUI.Label(position, text, style);
        position.y +=2;
        GUI.Label(position, text, style);
        position.y--;
        style.normal.textColor = inColor;
        GUI.Label(position, text, style);
        style = backupStyle;
    }
}
