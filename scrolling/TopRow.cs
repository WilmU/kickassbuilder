using UnityEngine;
using System.Collections;
using System;
public class TopRow : MonoBehaviour 
{
	public int Height;
	
	public int Width_;
	
	public int H;
	public int W;
	
	public Texture2D LeftButtonIcon;
	
	//public Texture2D[ ]	imgArr;
	//public GameObject[ ] furnitureObjects;
	public GUISkin Skin ;
	
	//public string[ ] Arr;
	
	int buttion_size = 64;
	
	//public GUIStyle AreaStyle;
	
	//private float hScrollbarValue;
	
	public Vector2 scrollPosition = Vector2.zero;
	
	public float Shown_Offset = 0;
	public float Hidden_Offset = 0;
	
	public float C_Offset = 0;
	public bool TabToggle = false;
	public float Target_Offset = 0;
	public float c_time = 0;
	
	public GUIContent[] Stuff;
	
	void Start()
	{
		Target_Offset= Hidden_Offset;	
	}
	
	void Update()
	{
		if(c_time < 1f)
		{
			c_time += Time.deltaTime;	
		}
		C_Offset= Mathf.Lerp(C_Offset,Target_Offset,c_time);
		
	}
	
	void OnGUI()
	{
		W = Screen.width;
		H = Screen.height;
		
		UpGUI();
	}
	void UpGUI()
	{
		// Gui.skin = skin allows the Guicontent to work
		GUI.skin=Skin;
		GUILayout.BeginArea (new Rect(0,0 - C_Offset,Screen.width,Screen.height));
		
		//if(GUILayout.Button("button"))
		//old scroll bar
		//hScrollbarValue = GUI.HorizontalScrollbar (new Rect (0,0, Screen.width, 30), hScrollbarValue, 1.0f, 0.0f, 10.0f);
		
		GUILayout.BeginHorizontal ();
		// the left side button for scrolling && LeftButtonIcon is the image
		
		//this is for the scrolling and scrollbar
		scrollPosition= GUILayout.BeginScrollView (scrollPosition,GUILayout.Width(150), GUILayout.Height(207));
		GUILayout.BeginVertical ();
		
			// the gui content is here that alows you to have text pics and other things.
		
		foreach(GUIContent gc in Stuff)
		{
			if(GUILayout.Button (gc,GUILayout.Width (buttion_size),GUILayout.Height (buttion_size)))
			{
				Debug.Log ("clicked on " + gc.text);
				}
			
		}
		
		
		
		GUILayout.EndVertical ();		
		GUILayout.EndScrollView();		
		
		// this is the scroll buttons height and width && LeftButtonIcon is the image
		
		GUILayout.EndHorizontal ();
		
		if(GUILayout.Button (DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"),GUILayout.Width (155)))
		{
			if(TabToggle==false)
			{
				TabToggle=true;
				Target_Offset = Shown_Offset;
				c_time=0f;
			}
			else
			{
				TabToggle=false;
				Target_Offset= Hidden_Offset;
				c_time=0f;
			}
		}
		GUILayout.EndArea();
		
	}
	
}

			