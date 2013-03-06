var speed : float = 0.8;
var score : GUIText;
var count : int = 0;

function Update ()
{
	transform.Translate(Vector3.forward * speed * Time.deltaTime);
	if (Input.GetKey("w"))
	{
		transform.Translate(Vector3.up * speed*2 * Time.deltaTime);
	}
	if (Input.GetKey("a"))
	{
		transform.Translate(Vector3.left * speed*2 * Time.deltaTime);
	}
	if (Input.GetKey("s"))
	{
		transform.Translate(Vector3.down * speed*2 * Time.deltaTime);
	}
	if (Input.GetKey("d"))
	{
		transform.Translate(Vector3.right * speed*2 * Time.deltaTime);
	}
	if (Input.GetKeyDown("space"))
	{
		speed = speed*3;
	}
	if (Input.GetKeyUp("space"))
	{
		speed = speed/3;
	}
}

function Collect (pAmount : int)
{
	count += pAmount;
	score.text = "Score: "+count.ToString();
}