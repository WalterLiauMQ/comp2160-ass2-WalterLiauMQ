using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{

    public bool CP1 = false;
    public bool CP2 = false;
    public bool CP3 = false;
    public bool CP4 = false;

    public GameObject checkpoint1;
    public GameObject checkpoint2;
    public GameObject checkpoint3;
    public GameObject checkpoint4;

    public GameObject winscreen;



    void Start()
    {
        checkpoint1.SetActive(true);
        checkpoint2.SetActive(false);
        checkpoint3.SetActive(false);
        checkpoint4.SetActive(false);
        winscreen.SetActive(false);
    }

    void Update()
    {

    }

    public void CP1reached()
    {
        checkpoint1.SetActive(false);
        checkpoint2.SetActive(true);
        Debug.Log("Checkpoint 1 reached");
    }

    public void CP2reached()
    {
        checkpoint2.SetActive(false);
        checkpoint3.SetActive(true);
        Debug.Log("Checkpoint 2 reached");
    }

    public void CP3reached()
    {
        checkpoint3.SetActive(false);
        checkpoint4.SetActive(true);
        Debug.Log("Checkpoint 3 reached");
    }

    public void CP4reached()
    {
        checkpoint4.SetActive(false);
        Debug.Log("Checkpoint 4 reached");
        WinGame();
    }

    public void WinGame()
    {
        winscreen.SetActive(true);
    }
}
