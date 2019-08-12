using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkToWindow : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: walk to window - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: walk to window - FAILED");
        return false;
    }
}
