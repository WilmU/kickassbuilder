using UnityEngine;
using System.Collections;

public class Lower_row : MonoBehaviour 
{
	public int Height;
	
	public Texture2D LeftButtonIcon;
	
	//public Texture2D[ ]	imgArr;
	//public GameObject[ ] furnitureObjects;
	public GUISkin Skin ;
	
	public GameObject transform;
	
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
		
		BottomGUI();
		/*
		GUI.skin= Skin;
		float Px = 0f;
		float Py = Screen.height - Height;
		float Sy = Height;
		float Sx = Screen.width;
		
		GUILayout.BeginArea(new Rect(Px,Py,Sx,Sy),Skin.box);
		
		float Sx2 = LeftButtonIcon.width;
		float Sy2 = LeftButtonIcon.height;
				
		GUI.Button(new Rect(Px,10,Sx2,Sy2), LeftButtonIcon); 
		
		GUI.Button(new Rect(922,10,Sx2,Sy2), LeftButtonIcon);
		
		GUILayout.Space(70);
		

		*/
		/*
		//scrollPostion = GUI.BeginScrollView(new Rect(Px,Py,Sx,Sy), scrollPostion, new Rect(Px/2f,Py,Sx/2f,Sy));
		scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(Screen.width), GUILayout.Height (100));		
		GUILayout.BeginHorizontal();
	
		
				foreach(string  item in Arr)
		{
			if(GUILayout.Button (item))
			{
				print (item);	
			}
		}
		
		GUILayout.EndHorizontal();
		
		GUI.EndScrollView();
		
		GUILayout.EndArea();
		*/
	}
	void BottomGUI()
	{
		// Gui.skin = skin allows the Guicontent to work
		GUI.skin=Skin;
		GUILayout.BeginArea (new Rect(0,Screen.height - C_Offset,Screen.width,140));
		
		if(GUILayout.Button ("TAB"))
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
		//if(GUILayout.Button("button"))
		//old scroll bar
		//hScrollbarValue = GUI.HorizontalScrollbar (new Rect (0,0, Screen.width, 30), hScrollbarValue, 1.0f, 0.0f, 10.0f);
		
		GUILayout.BeginHorizontal ();
		// the left side button for scrolling && LeftButtonIcon is the image
		if(GUILayout.Button (LeftButtonIcon,GUILayout.Width (buttion_size),GUILayout.Height (buttion_size)))
		{
			scrollPosition -= new Vector2(buttion_size,0);	
		}
		
		//foreach(Texture2D s in imgArr)
		//{
			//this is the middle buttons height and width
		//	 GUILayout.Button (s,GUILayout.Width(buttion_size),GUILayout.Height (buttion_size));	
		//}
		//this is for the scrolling and scrollbar
		scrollPosition= GUILayout.BeginScrollView (scrollPosition,GUILayout.Width (Screen.width - buttion_size * 2),GUILayout.Height (buttion_size + 30));
		GUILayout.BeginHorizontal ();
		
			// the gui content is here that alows you to have text pics and other things.
		
		foreach(GUIContent gc in Stuff)
		{
			if(GUILayout.Button (gc,GUILayout.Width (buttion_size),GUILayout.Height (buttion_size)))
			{
				Debug.Log ("clicked on " + gc.text);
				}
		}
		
		GUILayout.EndHorizontal ();		
		GUILayout.EndScrollView();		
		
		// this is the scroll buttons height and width && LeftButtonIcon is the image
		if(GUILayout.Button (LeftButtonIcon,GUILayout.Width (buttion_size),GUILayout.Height (buttion_size)))
		{
			scrollPosition += new Vector2(buttion_size,0);	
		}
		//foreach(string t in Arr + imgArr + s)
		//{
			
		//}
		GUILayout.EndHorizontal ();
		GUILayout.EndArea();
		
		
	}
	
}

			