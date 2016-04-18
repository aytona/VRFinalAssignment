using UnityEngine;
using System.Collections;

public class GunFiring : MonoBehaviour {
    public AudioSource soundSource;
    public AudioClip firingSound;
    public AudioClip scoringSound;
    public AudioClip poweringSound;
    public GameObject bulletParticle;
    private float healthPoints;

    void Start()
    {
        soundSource = GetComponent<AudioSource>();
        healthPoints = 100;
    }

	// Update is called once per frame
	void Update ()
    {
        checkIsDead();
        healthPoints-= Time.deltaTime * 2;
        Debug.Log(healthPoints);
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
                    soundSource.PlayOneShot(scoringSound, 0.5f);
                }
                if (hitInfo.collider.gameObject.CompareTag("Time"))
                {
                    Destroy(hitInfo.collider.gameObject);
                    soundSource.PlayOneShot(poweringSound, 0.5f);
                    healthPoints += 30;
                }
            }
        }
    
	}

    private void checkIsDead()
    {
        if (healthPoints <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public float GetHealth()
    {
        return healthPoints;
    }
}
