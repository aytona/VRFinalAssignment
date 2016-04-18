using UnityEngine;
using System.Collections;

public class GunFiring : MonoBehaviour {

    public AudioSource soundSource;
    public AudioClip firingSound;
    public GameObject bulletParticle;

    void Start()
    {
        soundSource = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () {
        RaycastHit hitInfo;
        //Fires a ray from the exact center of the screen, by getting the midpoint of the screen's width and height for X and Y
        Ray bulletRaycast = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)); 

        if(Input.GetMouseButtonDown(0))
        {
            soundSource.PlayOneShot(firingSound, 0.7f);
            if(Physics.Raycast(bulletRaycast, out hitInfo))
            {
                Object bullet = Instantiate(bulletParticle, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                Destroy(bullet, 0.5f);
                if (hitInfo.collider.gameObject.CompareTag("Destructible"))
                {
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }

	}
}
