using UnityEngine;
using System.Collections;

public class enemy_hit : MonoBehaviour {

	//all variables should be overridden when inheriting 
	public int points = 0;
	public int health = 8;

	public Sprite ship;
	public Sprite damage;
	public int frame_swap;

	public bool hasRelic = false; //only used by boss

	GameObject player;
	GameObject player2;

	public int getHealth(){
		return health;
	}

	void OnTriggerEnter(Collider c){
		if(player == null){
			player = GameObject.Find("player");
		}
		if(player2 == null && upgradeLORD.coop){
			player2 = GameObject.Find("player2(Clone)");
		}


		if (c.gameObject.ToString ().StartsWith ("player_shot")) {  //hit by shot
			GameObject go = (GameObject)Instantiate (Resources.Load ("explosion_small"));

			go.transform.Translate (c.transform.position.x, c.transform.position.y, c.transform.position.z);
						
			if (!gameObject.tag.ToString ().Equals ("Boss")) {
				show_damage ();  //show_good must be called by children
			}

		
			health -= Damage (c);
			if (!c.gameObject.ToString ().Contains ("beam")) {
				DestroyObject (c.gameObject); //destroy shot and missile but not beam
				if (c.gameObject.ToString ().Contains ("missile")) {
					Instantiate (Resources.Load ("Explosion_0"), c.gameObject.transform.position, gameObject.transform.rotation);
				}
			}
				
			if(health <= 0){

				string who = logShooter(c);
				if(who != null){
					if(who.Contains("player2")){
						player2.GetComponent<player2_behavior> ().setScore (player2.GetComponent<player2_behavior> ().getScore() + points);
					}

					else if(who.Contains("player")){
						player.GetComponent<player_behavior> ().setScore (player.GetComponent<player_behavior> ().getScore() + points);
					}
				}

				if(gameObject.ToString().StartsWith("Relic")){
					player_behavior.hasRelic = true;
				}
				else if(gameObject.ToString().Contains("boss")){
					if(Application.loadedLevel != 8){
						level_manager.levelFinished = true;
					}
					Instantiate(Resources.Load("expl huge"), gameObject.transform.position, gameObject.transform.rotation);

				}

				if(gameObject.ToString().Contains("space_boss")){
					Instantiate(Resources.Load("expl huge"), gameObject.transform.position, gameObject.transform.rotation);
					level_manager.levelFinished = true;
				}
				else{
					Instantiate(Resources.Load("expl 3"), gameObject.transform.position, gameObject.transform.rotation);
					
                    
				}

				if(gameObject.tag.ToString().Equals("Boss") || gameObject.tag.ToString().Equals("Relic")){
					giveUpgrade();
				}

				DestroyObject(this.gameObject);
			}
		}
	}

	int Damage(Collider c){
        int value;
        
        if ((c.gameObject.ToString().Contains("water") && gameObject.ToString().Contains("city"))   || 
            (c.gameObject.ToString().Contains("fire")  && gameObject.ToString().Contains("forest")) ||
            (c.gameObject.ToString().Contains("earth") && gameObject.ToString().Contains("water"))) {
            value = 2;
        } else {
		    value = 1;
		}
        if(c.gameObject.ToString().Contains("missile")){
			value = 2;
		}
		else if(c.gameObject.ToString().Contains("beam")){
			value = 8;
		}
		//standard shot
		return value;
	}

	string logShooter(Collider c){
		if (c.GetComponent<player_shot_behavior> () != null) {
			return c.GetComponent<player_shot_behavior> ().getShooter ();
		}
		if (c.GetComponent<player_missile>() != null) {
			return c.GetComponent<player_missile>().getShooter();
		}
		return null;
	}

	public void show_damage(){
		gameObject.GetComponent<SpriteRenderer>().sprite = damage;
		frame_swap = 5;
	}
	
	public void show_good(){
		gameObject.GetComponent<SpriteRenderer>().sprite = ship;
	}

	//call in all children's Start function if you want it to show damage
	public void loadSprite(){

		if(GetComponent<SpriteRenderer>().sprite.ToString().StartsWith("bad-ship-water2")){
			ship = Resources.Load<Sprite>("bad-ship-water2");
			damage = Resources.Load<Sprite>("bad-ship-water2-red");
		}
		else if(GetComponent<SpriteRenderer>().sprite.ToString().StartsWith("bad-ship-water")){
			ship = Resources.Load<Sprite>("bad-ship-water");
			damage = Resources.Load<Sprite>("bad-ship-water-red");
		}
		else if(GetComponent<SpriteRenderer>().sprite.ToString().StartsWith("bad-ship2")){
			ship = Resources.Load<Sprite>("bad-ship2");
			damage = Resources.Load<Sprite>("bad-ship2-red");
		}
		else if(GetComponent<SpriteRenderer>().sprite.ToString().StartsWith("bad-ship")){
			ship = Resources.Load<Sprite>("bad-ship");
			damage = Resources.Load<Sprite>("bad-ship-red");
		}
		else if(GetComponent<SpriteRenderer>().sprite.ToString().StartsWith("city-bad-ship2")){
			ship = Resources.Load<Sprite>("city-bad-ship2");
			damage = Resources.Load<Sprite>("city-bad-ship2-red");
        }
        else if (GetComponent<SpriteRenderer>().sprite.ToString().StartsWith("city-bad-ship"))
        {
            ship = Resources.Load<Sprite>("city-bad-ship");
            damage = Resources.Load<Sprite>("city-bad-ship-red");
        }
		else if(GetComponent<SpriteRenderer>().sprite.ToString().StartsWith("earth-bad-ship2")){
			ship = Resources.Load<Sprite>("earth-bad-ship2");
			damage = Resources.Load<Sprite>("earth-bad-ship2-red");
		}
		else if(GetComponent<SpriteRenderer>().sprite.ToString().StartsWith("earth-bad-ship")){
			ship = Resources.Load<Sprite>("earth-bad-ship");
			damage = Resources.Load<Sprite>("earth-bad-ship-red");
		}
		else if(GetComponent<SpriteRenderer>().sprite.ToString().Contains("relic")){
			if(Application.loadedLevel == 2){
				ship = Resources.Load<Sprite>("water relic");
				damage = Resources.Load<Sprite>("water relic hit");
			}
			else if(Application.loadedLevel == 4){
				ship = Resources.Load<Sprite>("fire relic");
				damage = Resources.Load<Sprite>("fire relic hit");
			}
			else if(Application.loadedLevel == 6){
				ship = Resources.Load<Sprite>("earth relic");
				damage = Resources.Load<Sprite>("earth relic hit");
			}
		}
	}

	void giveUpgrade(){
		player_behavior.hasRelic = true;
		
		if((Application.loadedLevel == 2 || (Application.loadedLevel == 8 && gameObject.ToString().Contains("water"))) && upgradeLORD.getWater == false){
			upgradeLORD.getWater = true;
			player.GetComponent<player_behavior> ().setElement ("water");
			if(player2 != null){
				player2.GetComponent<player2_behavior> ().setElement ("water");
			}
			upgradeLORD.total++;
		}
		else if((Application.loadedLevel == 4 || (Application.loadedLevel == 8 && gameObject.ToString().Contains("city"))) && upgradeLORD.getFire == false){
			upgradeLORD.getFire = true;
			player.GetComponent<player_behavior> ().setElement ("fire");
			if(player2 != null){
				player2.GetComponent<player2_behavior> ().setElement ("fire");
			}
			upgradeLORD.total++;
		}
		else if((Application.loadedLevel == 6 || (Application.loadedLevel == 8 && gameObject.ToString().Contains("forest"))) && upgradeLORD.getEarth == false){
			upgradeLORD.getEarth = true;
			player.GetComponent<player_behavior> ().setElement ("earth");
			if(player2 != null){
				player2.GetComponent<player2_behavior> ().setElement ("earth");
			}
			upgradeLORD.total++;
		}

	}


}
 