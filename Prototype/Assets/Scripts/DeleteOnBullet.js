var bullet : GameObject;

function OnCollisionEnter (pCollider : Collision) 
{
	print(pCollider.collider.name);
	if (pCollider.collider.name == bullet.name+"(Clone)")
	{
		Destroy(this.gameObject);
	}
}