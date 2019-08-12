using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkToDoor : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: walk to door - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: walk to door - FAILED");
        return false;
    }
}
