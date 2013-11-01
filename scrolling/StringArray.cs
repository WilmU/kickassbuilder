using UnityEngine;
using System.Collections;
public class StringArray : MonoBehaviour 
{
	
	string [] strArray;
	void Start () 
	{
	strArray = new string[3] { "table", "chair", "desk"};
	}
	
	void OnGUI () 
	{
		if (GUI.Button (new Rect (300,10,100,100), strArray[2])) 
		{
			print (strArray[2]);
		}
		if (GUI.Button (new Rect (150,10,100,100), strArray[1])) 
		{
			print (strArray[1]);
		}
		if (GUI.Button (new Rect (10,10,100,100), strArray[0])) 
		{
			print (strArray[0]);
		}
	}
}