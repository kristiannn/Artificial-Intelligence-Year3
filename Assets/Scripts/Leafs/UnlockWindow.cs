using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockWindow : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: unlock window - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: unlock window - FAILED");
        return false;
    }
}
