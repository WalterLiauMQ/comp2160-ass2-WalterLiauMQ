using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public CarHealth carHealth;

    public bool CP1 = false;
    public bool CP2 = false;
    public bool CP3 = false;
    public bool CP4 = false;

    public GameObject checkpoint1;
    public GameObject checkpoint2;
    public GameObject checkpoint3;
    public GameObject checkpoint4;

    // Amount of health restored by individual checkpoints
    public float CP1HealthRestore = 30;
    public float CP2HealthRestore = 30;
    public float CP3HealthRestore = 30;
    public float CP4HealthRestore = 30;


    void Start()
    {
        checkpoint1.SetActive(true);
        checkpoint2.SetActive(false);
        checkpoint3.SetActive(false);
        checkpoint4.SetActive(false);
    }

    public void CP1reached()
    {
        carHealth.checkpointHPRestore(CP1HealthRestore);
        checkpoint1.SetActive(false);
        checkpoint2.SetActive(true);
        GameManager.Instance.CheckpointTime(1);
        Debug.Log("Checkpoint 1 reached");
    }

    public void CP2reached()
    {
        carHealth.checkpointHPRestore(CP2HealthRestore);
        checkpoint2.SetActive(false);
        checkpoint3.SetActive(true);
        GameManager.Instance.CheckpointTime(2);
        Debug.Log("Checkpoint 2 reached");
    }

    public void CP3reached()
    {
        carHealth.checkpointHPRestore(CP3HealthRestore);
        checkpoint3.SetActive(false);
        checkpoint4.SetActive(true);
        GameManager.Instance.CheckpointTime(3);
        Debug.Log("Checkpoint 3 reached");
    }

    public void CP4reached()
    {
        carHealth.checkpointHPRestore(CP4HealthRestore);
        checkpoint4.SetActive(false);
        Debug.Log("Checkpoint 4 reached");
        GameManager.Instance.CheckpointTime(4);
        UIManager.Instance.WinGame();
    }


}
