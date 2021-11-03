using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint3 : MonoBehaviour
{

    public CheckpointManager checkpointManager;

    void OnTriggerEnter(Collider collider)
    {
        checkpointManager.CP3reached();
    }
}
