using UnityEngine;
using System.Collections;
using System;

public class death_script : MonoBehaviour {

    private GUIStyle textstyle = new GUIStyle();

	int count = 50;

	// Update is called once per frame
	void Update () {
		count--;
			if(count < 0){

			bool start = Input.anyKey ;
			
			if(start){
				Application.LoadLevel(0);
			}
		}
	}

    void OnGUI() {
        textstyle.normal.textColor = UnityEngine.Color.white;
        textstyle.alignment = TextAnchor.MiddleCenter;
        textstyle.fontSize = 32;

        string final = string.Format("Player 1 Final Score: {0}", upgradeLORD.p1score);
        drawOutline(new Rect(0, (float)0.6 * UnityEngine.Screen.height, (float)UnityEngine.Screen.width, (float)0.0128 * UnityEngine.Screen.height), final, textstyle, Color.black, Color.white);
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
