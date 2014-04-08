using UnityEngine;
using System.Collections;

public class enemy_health_script : MonoBehaviour {

	public int generateHealth(string name){

		if (name.StartsWith("vert") || name.StartsWith("towards")) {
			return 3;
		} else if(name.StartsWith("water") && !name.Contains("b")){
			return 20;
		} else {
            return 15;
        }
	}
}
