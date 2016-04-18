using UnityEngine;
using System.Collections;

public class RotatingCoinm : MonoBehaviour {
    public float rotationSpeed = 150;

	// Update is called once per frame
	void Update () {
        transform.Rotate(0, rotationSpeed * Time.deltaTime * 7, 0);
	}
}
