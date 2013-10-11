#pragma strict

	public var ball : GameObject;
	private var playerBall : GameObject;
	public var spacing : float;
	
	var startCube : GameObject;
	var boundriesZ : float;
	var boundriesX : float;
	
function Start () {

	var aP : GameObject;
	var numRows: int = 9;
	var numCols: int = 9;
	
	for(var row:int = 0; row <= numRows; row++)
	{
		for(var col:int = 0; col <= numCols; col++)
		{
			aP = GameObject. CreatePrimitive(PrimitiveType.Cube);
			aP.transform.position.z = col * spacing;
			aP.transform.position.x = row * spacing;
			aP.name = "box_" + col + "_" + row;
		}
	}
	playerBall = Instantiate(ball,Vector3(0,1,0),Quaternion.identity);
	startCube = GameObject.Find("box_0_0");
	playerBall.transform.position.x = startCube.transform.position.x;
	playerBall.transform.position.z = startCube.transform.position.z;
	var info : ballMovement = playerBall.GetComponent(ballMovement);
	info.moveSpace = spacing;
	
	boundriesZ = numCols * spacing;
	boundriesX = numRows * spacing;
	info.newBoundriesZ = boundriesZ;
	info.newBoundriesX = boundriesX;
	
}
