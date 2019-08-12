using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashDoor : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: smash door - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: smash door - FAILED");
        return false;
    }
}
