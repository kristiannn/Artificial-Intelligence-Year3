using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: close window - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: close window - FAILED");
        return false;
    }
}
