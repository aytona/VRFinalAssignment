using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
    private float playerHitpoints;
    public GunFiring gunFiring;
    public Slider healthSlider;

	// Update is called once per frame
	void Update () {
        playerHitpoints = gunFiring.GetHealth();
        healthSlider.value = playerHitpoints;
    }
}
