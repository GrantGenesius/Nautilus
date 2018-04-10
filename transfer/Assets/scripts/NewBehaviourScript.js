//Script to drag an object in world space using the mouse
 
 
var screenSpace;
var offset;
 
function OnMouseDown(){
    //translate the cubes position from the world to Screen Point
    screenSpace = Camera.main.WorldToScreenPoint(transform.position);
     
    //calculate any difference between the cubes world position and the mouses Screen position converted to a world point  
    offset = transform.position - Camera.main.ScreenToWorldPoint(Vector3(Input.mousePosition.x,Input.mousePosition.y, screenSpace.z));
   
}
 
/*
OnMouseDrag is called when the user has clicked on a GUIElement or Collider and is still holding down the mouse.
OnMouseDrag is called every frame while the mouse is down.
*/
 
function OnMouseDrag () {
 
    //keep track of the mouse position
    var curScreenSpace = Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);    
 
    //convert the screen mouse position to world point and adjust with offset
    var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset + Vector3.up;
 
    //update the position of the object in the world
    transform.position = curPosition;
}