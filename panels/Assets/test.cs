using UnityEngine;
using System.Collections;
using Holoville.HOTween;
using Holoville.HOTween.Plugins;

public class test : MonoBehaviour {
	
	public GameObject panelHeader;
	public GameObject panelBody;
	private TweenParms paramHeader = new TweenParms();
	private TweenParms paramBody   = new TweenParms();
	private TweenParms paramHeaderR = new TweenParms();
	private TweenParms paramBodyR  = new TweenParms();
	private Vector3 initSclHeader, initSclBody, initPosHeader, initPosBody;
	private float dur1 = 0.5f;
	private float dur2 = 0.5f;
	private bool bExpand = false;
	
	// Use this for initialization
	void Start () {
		//Tween Parameters
		initSclHeader = new Vector3(0.0f, 1.0f, 1.0f);
		initSclBody   = new Vector3(1.0f, 0.0f, 1.0f);
		initPosHeader = new Vector3(10.0f, 0.0f, 0.0f);
		initPosBody   = new Vector3(-5.0f, 5.0f, 0.0f);
		 
		//Expand 
		paramHeader.Prop ("localScale", panelHeader.transform.localScale);
		paramHeader.Prop("position", panelHeader.transform.position);
		paramHeader.Ease(EaseType.EaseOutQuad);
		paramHeader.Delay (0.5f);
		
		paramBody.Prop ("localScale", panelBody.transform.localScale);
		paramBody.Prop("position", panelBody.transform.position);
		paramBody.Ease(EaseType.EaseOutQuad);
		paramBody.Delay (0.8f);
		
		//Shrink
		paramBodyR.Prop("localScale", initSclBody);
		paramBodyR.Prop("position", initPosBody);
		paramBodyR.Ease(EaseType.EaseOutQuad);
		paramBodyR.Delay (0.5f);
		
		paramHeaderR.Prop ("localScale", initSclHeader);
		paramHeaderR.Prop ("postision", initPosHeader);
		paramHeaderR.Ease(EaseType.EaseOutQuad);
		paramHeaderR.Delay (0.8f);
		
		
		//Panel Initial State
		panelHeader.transform.localScale = initSclHeader;
		panelBody.transform.localScale = initSclBody;
		panelHeader.transform.position = initPosHeader;
		panelBody.transform.position   = initPosBody;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			if(bExpand){
				Shrink();
			}else{
				Expand ();
			}
			bExpand = !bExpand;
		}
	}
	 
	void Expand(){
		HOTween.To (panelHeader.transform, dur1, paramHeader);
		HOTween.To (panelBody.transform, dur2, paramBody);
	}
	
	void Shrink(){
		HOTween.To (panelBody.transform, dur2, paramBodyR);
		HOTween.To (panelHeader.transform, dur1, paramHeaderR);
	}
}
