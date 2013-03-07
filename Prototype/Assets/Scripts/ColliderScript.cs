using UnityEngine;
using System.Collections;

public class ColliderScript : MonoBehaviour {
	
	public GameObject collectible;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void onCollisionEnter(Collider collider)
	{
		Debug.Log ("Collision!");
		if(collider.tag == "Collectible"){
			Destroy (collider.gameObject);
			Debug.Log ("Collided!");
		}
	}
}
