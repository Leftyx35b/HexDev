public var type : LightType;
public var color : Color;
public var range : float;
public var intensity : float;
public var cookie : Texture;
public var speed : float;
public var emission : float;
public var duration : float;
public var sound : AudioClip;

private var bullets = new Array();
private var stop = false;
private var shoot = true;


function Update () 
{
	if (shoot == true)
	{
		ShootBullet();
	}
}

function SendDestroy()
{
	var temp : GameObject = bullets.pop();
	temp.AddComponent("BulletBehaviour");
	temp.SendMessage("DoDestroy",duration);
}

function ShootBullet()
{
	shoot = false;
	var bullet : GameObject = new GameObject();
	bullet.AddComponent("Light");
	bullet.light.type = type;
	bullet.light.color = color;
	bullet.light.range = range;
	bullet.light.spotAngle = 180;
	bullet.light.cookie = cookie;
	bullet.light.intensity = intensity;
	bullet.transform.position = this.transform.position;
	bullet.transform.rotation = this.transform.rotation;
	bullets.push(bullet);
	this.audio.PlayOneShot(sound);
	SendDestroy();
	yield WaitForSeconds(emission);
	shoot = true;
}