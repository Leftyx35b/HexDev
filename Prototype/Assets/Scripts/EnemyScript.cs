using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	public float xMove = 8f;
	public float yMove = 1.5f;
	public float moveSpeed = 0.02f;
	public float forwardSpeed = 0.3f;
	
	public int ticksUntilDrop = 0;
	public int maxTicksBetweenDrops = 800;
	public int minTicksBetweenDrops = 100;
	
	public Transform relicPrefab;
	
	private float moveStep = 0f;
	private float centerX;
	private float centerY;
	
	// Use this for initialization
	void Start () {
		centerX = transform.position.x;
		centerY = transform.position.y;
		ticksUntilDrop = Random.Range(minTicksBetweenDrops, maxTicksBetweenDrops);
	}
	
	// Update is called once per frame
	void Update () {		
		transform.Translate(0,0,forwardSpeed);
		moveStep += moveSpeed;
		transform.position = new Vector3(centerX + xMove * Mathf.Sin (moveStep),
							 			centerY + yMove * Mathf.Cos (moveStep+Mathf.PI),
									 	transform.position.z);
		
		ticksUntilDrop--;
		if(ticksUntilDrop <= 0) {
			Instantiate (relicPrefab, transform.position, transform.rotation);
			ticksUntilDrop = Random.Range(minTicksBetweenDrops, maxTicksBetweenDrops);
		}
	}
}
