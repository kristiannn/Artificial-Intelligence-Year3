using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: close door - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: close door - FAILED");
        return false;
    }
}
