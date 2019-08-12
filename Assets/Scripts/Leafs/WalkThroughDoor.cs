using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkThroughDoor : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: walk through door - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: walk through door - FAILED");
        return false;
    }
}
