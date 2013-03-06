using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public float moveSpeed = 1;
	public float maxTouchDist = 120f;
	public float forwardSpeed = 0.2f;
	public bool debugMovement = false;	//Set variable private and false at release
	
	private float centerX = Screen.width / 2.0f;
	private float centerY = Screen.height / 2.0f;
	private Vector3 oldPos;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		oldPos = transform.position;
		
		if (debugMovement) {
			if (Input.GetKey(KeyCode.UpArrow)) {
				transform.Translate(0,moveSpeed,0);
			}
			if (Input.GetKey(KeyCode.DownArrow)) {
				transform.Translate(0,-moveSpeed,0);	
			}
			if (Input.GetKey(KeyCode.LeftArrow)) {
				transform.Translate(-moveSpeed,0,0);	
			}
			if (Input.GetKey(KeyCode.RightArrow)) {
				transform.Translate(moveSpeed,0,0);
			}
		}
		else
		{
			if (Input.GetMouseButton(0)) {
				Vector3 mousePos = Input.mousePosition;
				float dist = getDistToCenter(mousePos.x, mousePos.y);
				float speed = moveSpeed * (dist / maxTouchDist);
				float angle = getAngleToCenter(mousePos.x, mousePos.y);
				
				transform.Translate (Mathf.Cos(angle)*speed, Mathf.Sin(angle)*speed, 0);
			}
		}
		transform.Translate(0,0,forwardSpeed);
		
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
    	if (Physics.Raycast (transform.position, fwd,  1.0f)) {
        	Debug.Log ("front!");
			transform.position = oldPos;
    	}
		
		Vector3 dwn = transform.TransformDirection (Vector3.down);
    	if (Physics.Raycast (transform.position, dwn, 1.0f)) {
        	Debug.Log ("Down!");
			transform.position = oldPos;
    	}
		
		Vector3 lft = transform.TransformDirection (Vector3.left);
			if (Physics.Raycast (transform.position, lft, 1.0f)) {
	        Debug.Log ("Left!");
			transform.position = oldPos;
	    }
		
		Vector3 rigt = transform.TransformDirection (Vector3.right);
	    if (Physics.Raycast (transform.position, rigt, 1.0f)) {
	        Debug.Log ("Right!");
			transform.position = oldPos;
	    }
	}
	
	private float getDistToCenter(float posX, float posY) {
		float diffX = Mathf.Abs(centerX - posX);
		float diffY = Mathf.Abs(centerY - posY);
		float res = (diffX*diffX) + (diffY*diffY);
		res = Mathf.Sqrt(res);
		if (res > maxTouchDist) { res = maxTouchDist; }
		Debug.Log (res);
		return res;
	}
	
	private float getAngleToCenter(float posX, float posY) {
		float diffX = posX - centerX;
		float diffY = posY - centerY;
		float angle = Mathf.Atan2(diffY, diffX);
		//Debug.Log (angle);
		return angle;
	}
}
