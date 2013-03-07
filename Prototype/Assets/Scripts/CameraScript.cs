using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	
	private PlayerScript player;
	private float pipeRadius = 110.0f;
	private float pipeLength = 0.0f;
	private float totalStep = 0.0f;
	private bool moving = false;
	
	public float rotationX = 0.0f;
	public float rotationY = 0.0f;
	
	// Use this for initialization
	void Start () {
		player = gameObject.GetComponent("PlayerScript") as PlayerScript;
	}
	
	// Update is called once per frame
	void Update () {
		if(moving){
			float speed = player.forwardSpeed;
			float step = speed / pipeLength;
			if(step+totalStep > 1.0f) { step = 1.0f - totalStep; }
			totalStep += step;
			
			transform.RotateAroundLocal(transform.right, -step*rotationX/360*2*Mathf.PI);
			transform.RotateAroundLocal(transform.up, step*rotationY/360*2*Mathf.PI);
			
			if(totalStep >= 1.0f) { moving = false; }
		}
	}
	
	public void StartRotation(float x, float y){
		if(moving){ return; }
		rotationX = x;
		rotationY = y;
		moving = true;
		
		float angle = Mathf.Max(rotationX, rotationY);
		float circumference = 2 * Mathf.PI * pipeRadius;
		pipeLength = (angle/360.0f) * circumference;
	}
}
