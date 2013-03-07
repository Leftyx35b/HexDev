using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {
	
	public int rockets;
	public int currentSpeed;
	private string controls = "tap and drag to move left right up and down, tap on the target reticle to shoot";
	public string bottomLeftHud = "      Speed           Health";
	public string bottomRightHud = "      Rockets        Relics";
	public Texture target;
	int collectedRelics;
	int health;
	int damage;
	public float sizeHUDX = 200f;
	public float sizeHUDY = 100f;
	GameObject player;
	
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Sub");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		controls = GUI.TextArea(new Rect(0,0,sizeHUDX/2,sizeHUDY), controls);
		GUI.BeginGroup(new Rect(0, Screen.height-sizeHUDY, sizeHUDX, sizeHUDY));
		bottomLeftHud = GUI.TextArea(new Rect(0, 0, sizeHUDX, sizeHUDY), bottomLeftHud);
		GUI.Label(new Rect(sizeHUDX/8, sizeHUDY/2,sizeHUDX/2, sizeHUDY/2), currentSpeed.ToString() + "  KMH");
		GUI.Label(new Rect(sizeHUDX/2, sizeHUDY/2,sizeHUDX/2, sizeHUDY/2), health.ToString() + "  HLTH");
		GUI.EndGroup();
		GUI.BeginGroup(new Rect(Screen.width-sizeHUDX, Screen.height-sizeHUDY, sizeHUDX, sizeHUDY));
		bottomRightHud = GUI.TextArea(new Rect(0,0, sizeHUDX, sizeHUDY), bottomRightHud);
		GUI.Label(new Rect(sizeHUDX/8, sizeHUDY/2,sizeHUDX/2, sizeHUDY/2), rockets.ToString() + "  RKTS");
		GUI.Label(new Rect(sizeHUDX/2, sizeHUDY/2,sizeHUDX/2, sizeHUDY/2), collectedRelics.ToString() + "  RLCS");
		GUI.EndGroup();
		GUI.DrawTexture(new Rect((Screen.width-64)/2,(Screen.height-64)/2,64,64),target);
	}
}