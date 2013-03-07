var player : GameObject;
var counter : GameObject;

function OnTriggerEnter (pCollider : Collider) 
{
	print("++++");
	if (pCollider.name == "Player")
	{
		var counter:GameObject = GameObject.Find("Score");
		Destroy(this.gameObject);
		//counter.SendMessage("Collect",1);
	}
}

function Update ()
{
	//transform.Rotate(2,6,2);
}