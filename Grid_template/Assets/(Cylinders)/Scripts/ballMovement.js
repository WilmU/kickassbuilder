#pragma strict

public var moveSpace : float;
private var moving : boolean;

var newBoundriesZ : float;
var newBoundriesX : float;

function Start () {

}

function Update () {
	if (moving == false)
	{
		if (Input.GetKeyDown("w") && transform.position.z < newBoundriesZ)
		{
			transform.position.z += moveSpace;
			}
		if (Input.GetKeyDown("a") && transform.position.x > 0)
		{
			transform.position.x -= moveSpace;
			}
		if (Input.GetKeyDown("s") && transform.position.z > 0)
		{
			transform.position.z -= moveSpace;
			}
		if (Input.GetKeyDown("d") && transform.position.x < newBoundriesX)
		{
			transform.position.x += moveSpace;oidfhigeoijoi;ar
			}
		
	}

}
