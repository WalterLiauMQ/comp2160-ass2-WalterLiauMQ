using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    public CheckpointManager checkpointManager;

    void OnTriggerEnter(Collider collider)
    {
        checkpointManager.CP2reached();
    }
}
