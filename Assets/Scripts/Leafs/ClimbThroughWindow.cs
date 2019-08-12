using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbThroughWindow : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: climb through window - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: climb through window - FAILED");
        return false;
    }
}
