using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint1 : MonoBehaviour
{
    public CheckpointManager checkpointManager;

    void OnTriggerEnter(Collider collider)
    {
        checkpointManager.CP1reached();
    }
}
