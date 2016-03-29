using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	public string attribName;
	public int attribAmount;

	public PlayerStats(string name, int amount) {
		attribName = name;
		attribAmount = amount;
	}

	// Set default attrib amount to 1
	public int CompareTo(PlayerStats other) {
		if (other == null)
			return 1;
		return attribAmount - other.attribAmount;
	}
}
