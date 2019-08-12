using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindow : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: open window - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: open window - FAILED");
        return false;
    }
}
