using UnityEngine;
using System.Collections;

public class enemy_score_script : MonoBehaviour {

	public int generateScore(string name){
		
		if (name.StartsWith("vert") || name.StartsWith("towards")) {
			return 100;
		} else {
            return 200;
        }
	}
}
