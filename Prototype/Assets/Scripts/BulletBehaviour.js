function DoDestroy (pDuration : float) 
{
	yield WaitForSeconds(pDuration);
	Destroy(this.gameObject);
}

function Update()
{
	transform.Translate(Vector3.forward * 20 * Time.deltaTime);
	this.light.intensity -= 0.001;
	//this.light.range -= 50;
}