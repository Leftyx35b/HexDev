using UnityEngine;
using System.Collections;

public class CameraMoverCollider : MonoBehaviour {
	
	public float rotationX = 0.0f;
	public float rotationY = 0.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider collider)
	{
		if(collider.name == "Player"){
			CameraScript camera = collider.gameObject.GetComponent("CameraScript") as CameraScript;
			camera.StartRotation(rotationX, rotationY);
		}
	}
}
