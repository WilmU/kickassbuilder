using UnityEngine;
using System.Collections;

public class DynamicArray : MonoBehaviour 
{

	
	public string[] Arr;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		foreach(string item in Arr)
		{
			if(GUILayout.Button (item))
			{
				print (item);	
			}
		}
		
	}
}
