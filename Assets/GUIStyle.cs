using UnityEngine;
using System.Collections;

public class GUIStyle : MonoBehaviour {

	public GUISkin myGuiskin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = myGuiskin;
		GUI.Button (new Rect (300, 200, 150, 80), "Hello World");
		GUI.skin = null;
		GUI.Button (new Rect (500, 200, 150, 80), "New Hello World");
		GUI.skin = myGuiskin;
		GUI.Button (new Rect (700, 200, 150, 80), "Hello World");
		GUI.skin = null;
		GUI.Button (new Rect (900, 200, 150, 80), "New Hello World");
	}
}
