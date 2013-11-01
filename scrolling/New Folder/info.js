    var text = "rawr";
      var textObject : GUIText;
      var fishInfo = "Rawr!";
      var xPosition : float;
      var mySkin : GUISkin;
      var aTexture : Texture;
      
      
var yPosition : float;
var zPosition : float;
var xScale: float;
var yScale: float;
var zScale: float;

var gos : GameObject[];
var startPos : Vector3;
var startRot : Quaternion;
     

     
    private var currentToolTipText = "";
    private var guiStyleFore : GUIStyle;
    private var guiStyleBack : GUIStyle;
     
    function Start()
    {
    guiStyleFore = new GUIStyle();
    guiStyleFore.normal.textColor = Color.white;
    guiStyleFore.alignment = TextAnchor.UpperCenter ;
    guiStyleFore.wordWrap = true;
    guiStyleBack = new GUIStyle();
    guiStyleBack.normal.textColor = Color.black;
    guiStyleBack.alignment = TextAnchor.UpperCenter ;
    guiStyleBack.wordWrap = true;
     startPos = transform.position;
startRot = transform.rotation;
    }
     
    function OnMouseEnter ()
    {


    
    currentToolTipText = text;
             textObject.text = gameObject.name;
             

    }
     
    //function OnMouseExit ()
    //{
    //currentToolTipText = "";
    //}
     
    function OnGUI()
    {
    if (currentToolTipText != "")
    {
    	GUI.DrawTexture(Rect(10,10,175,293), aTexture);
     GUI.skin = mySkin;
    var x = Event.current.mousePosition.x;
    var y = Event.current.mousePosition.y;
    GUI.Label (Rect (x-149,y+40,300,60), currentToolTipText, guiStyleBack);
    GUI.Label (Rect (x-150,y+40,300,60), currentToolTipText, guiStyleFore);
    GUI.Box(Rect(22,50,150,20), text);
     GUI.Box(Rect(22,70,150,20), "Position");
        GUI.Box(Rect(22,90,150,20), transform.position.ToString());
            GUI.Box(Rect(22,170,150,20), transform.localScale.ToString());
        gos = GameObject.FindGameObjectsWithTag("Player");
 GUI.Box(Rect(22,110,150,20), "Number on Field");
  GUI.Box(Rect(22,150,150,20), "Scale");
 GUI.Box(Rect(22,130,150,20), gos.length.ToString());
if (GUI.Button (Rect(22,220, 150, 20), "Website"))
   {
    Application.OpenURL("http://www.amazon.com/Caravan-Canopy-Oversize-Gravity-Chair/dp/B0046A30VG/ref=lp_3733491_1_1?s=furniture&ie=UTF8&qid=1382111096&sr=1-1");
    }
 
  if (GUI.Button (Rect (10,400,50,25), "Reset")) {
print ("Resetting original position");
transform.position = startPos;
transform.rotation = startRot;
}
if (GUI.Button (Rect (60,400,50,25), "Delete")) {
Destroy (gameObject);
}
        }
        
    }
    
    
    



 
function Update () {

xPosition = transform.position.x;
yPosition = transform.position.y;
zPosition = transform.position.z;

xScale = transform.localScale.x;
yScale = transform.localScale.y;
zScale = transform.localScale.z;

}

    
   