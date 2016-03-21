using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// HUD States the player can be in
// Initialized in this script
public enum PlayerHUDState {
	inPause = 1,
	inConvo = 2,
	inGame = 3
}

// This script handles the player/main HUD
public class PlayerHUD : MonoBehaviour {

	#region Containers

	public GameObject inGameContainer = null;
	public GameObject inPauseContainer = null;
	public GameObject inConvoContainer = null;

	#endregion Containers

	#region inGameObjects

	public Text ammoCount = null;
	public Slider hpSlide = null;

	#endregion inGameObjects

	private PlayerHUDState currentState;

	void Start() {
		currentState = PlayerHUDState.inGame;
	}

	void Update() {
		CheckState();

		ammoCount.text = "∞/∞";				// TODO: Change this to reflect the actual ammo count
	}

	private void CheckState () {
		if (currentState == PlayerHUDState.inPause) {
			inGameContainer.gameObject.SetActive (false);
			inPauseContainer.gameObject.SetActive (true);
			inConvoContainer.gameObject.SetActive (false);
		}

		else if (currentState == PlayerHUDState.inConvo) {
			inGameContainer.gameObject.SetActive (false);
			inPauseContainer.gameObject.SetActive (false);
			inConvoContainer.gameObject.SetActive (true);
		}

		else if (currentState == PlayerHUDState.inGame) {
			inGameContainer.gameObject.SetActive (true);
			inPauseContainer.gameObject.SetActive (false);
			inConvoContainer.gameObject.SetActive (false);
		}
	}
}