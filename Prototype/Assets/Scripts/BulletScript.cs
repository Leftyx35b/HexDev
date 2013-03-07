using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	public float speed = 0.4f;
	public int lifeTime = 200;
	private int lifeTimeCounter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,speed);
		
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
    	if (Physics.Raycast (transform.position, fwd,  1.0f)) {
			Destroy(this.gameObject);
			Debug.Log("hit");
    	}
		if(lifeTimeCounter > lifeTime){
			Destroy (this.gameObject);
			
		}
		lifeTimeCounter++;
	}
}
