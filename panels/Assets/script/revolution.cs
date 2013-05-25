using UnityEngine;
using System.Collections;

public class revolution : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.RotateAround(Vector3.up, 0.02f);
	}
	
}
