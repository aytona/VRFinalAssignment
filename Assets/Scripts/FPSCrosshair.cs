using UnityEngine;
using System.Collections;

public class FPSCrosshair : MonoBehaviour {
    public Texture2D crosshair;

    private float crossHeight;
    private float crossWidth;
    private Rect screenCenter;

    // Use this for initialization
    void Start()
    {
        crossHeight = crosshair.height / 2;
        crossWidth = crosshair.width / 2;
        screenCenter = new Rect( (Screen.width - crossWidth) / 2, (Screen.height - crossHeight) / 2, crossWidth, crossHeight);

        GUI.DrawTexture(screenCenter, crosshair);
    }
}
