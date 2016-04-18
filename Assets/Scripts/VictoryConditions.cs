using UnityEngine;
using System.Collections;

public class VictoryConditions : MonoBehaviour {
    public GameObject[] targets;
    public GameObject victoryOverlay;
    private int targetsLeft;
    private bool gameComplete;
    

    void Start()
    {
        victoryOverlay.SetActive(false);
        gameComplete = false;
    }

    void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("Destructible");
        targetsLeft = targets.Length;
        if (targetsLeft == 0)
        {
            gameComplete = true;
        }
    }

    void OnGUI()
    {
        if(gameComplete == true)
        {
            Time.timeScale = 0;
            victoryOverlay.SetActive(true);
        }
    }
}
