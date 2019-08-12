using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: unlock door - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: unlock door - FAILED");
        return false;
    }
}
