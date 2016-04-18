@script RequireComponent(AudioSource)
 
var front : AudioClip;

var back: AudioClip;

function Update(){
 
    if (Input.GetButtonDown("Fire1"))
    { 
        GetComponent.<AudioSource>().PlayOneShot(front, 1.0);
    }
 
}