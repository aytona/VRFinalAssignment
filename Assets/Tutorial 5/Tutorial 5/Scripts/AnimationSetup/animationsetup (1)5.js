 //Very Simple Animation Setup (v2.0 TUT 5). By; Alec Markarian (http://www.youtube.com/user/misterninjaboy)

//Key down 
     function Update()
{
 if(Input.GetKeyDown("space"))
 {
  // Plays the Jump animation - stops all other animations
  GetComponent.<Animation>().Play("jump", PlayMode.StopAll);
 }
}