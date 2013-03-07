var fadeSpeed : float;
var intensityMax : float;
var waitFor : float;
private var intensity : float = 0;
private var phase = 0;
private var wait : float = 0;

function Start()
{
	randomIntensity();
}

function Update () 
{
	if (phase == 0)
	{
		FadeIn();
	}
	if (phase == 1)
	{
		Wait();
	}
	if (phase == 2)
	{
		FadeOut();
	}
}

function FadeIn()
{
	if (this.light.intensity <= intensity)
	{
		this.light.intensity += fadeSpeed;
	}
	else
	{
		phase = 1;
	}
}

function Wait()
{
	if (wait <= waitFor)
	{
		wait += fadeSpeed;
	}
	else
	{
		phase = 2;
	}
}

function FadeOut()
{
	if (this.light.intensity > 0)
	{
		this.light.intensity -= fadeSpeed;
	}
	else
	{
		randomIntensity();
		phase = 0;
	}
}

function randomIntensity()
{
	intensity = Random.Range(0,intensityMax);
}