using UnityEngine;
using System.Collections;

public class EnemyRotateScript : MonoBehaviour {
	
	private EnemyScript enemy;
	private float pipeRadius = 110.0f;
	private float pipeLength = 0.0f;
	private float totalStep = 0.0f;
	private bool moving = false;
	
	public float rotationX = 0.0f;
	public float rotationY = 0.0f;
	
	// Use this for initialization
	void Start () {
		enemy = gameObject.GetComponent("EnemyScript") as EnemyScript;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
