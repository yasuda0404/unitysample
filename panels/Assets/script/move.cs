using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")){
            print ("space key was pressed Time.timeScale="+Time.timeScale);
			Time.timeScale = Mathf.Abs (1.0f-Time.timeScale);
		}

	}
	void FixedUpdate(){
		transform.Translate(0.01f*Vector3.up);
	}
	
	void OnGUI(){
		GUILayout.BeginArea(new Rect(32f,32f,200f,64f));
		GUILayout.Label("Push space to stop/resume motion");
		GUILayout.EndArea();
	}
}
