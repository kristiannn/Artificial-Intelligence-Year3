using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: open door - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: open door - FAILED");
        return false;
    }
}
