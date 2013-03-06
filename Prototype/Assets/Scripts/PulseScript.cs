using UnityEngine;
using System.Collections;

public class PulseScript : MonoBehaviour {
	public int start = -20;
	public int end = 100;
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(0, 0, speed);
		if(gameObject.transform.localPosition.z > end){
			gameObject.transform.localPosition = new Vector3(0, 0, start);	
		}
	}
}
