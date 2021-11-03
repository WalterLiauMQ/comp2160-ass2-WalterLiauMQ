using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint4 : MonoBehaviour
{

    public CheckpointManager checkpointManager;

    void OnTriggerEnter(Collider collider)
    {
        checkpointManager.CP4reached();
    }
}
