using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashWindow : Node {

    public bool success = true;

    //Uses Execute from Node
    public override bool Execute()
    {
        if (success)
        {
            Debug.Log("Leaf: smash window - SUCCESSFUL");
            return true;
        }
        Debug.Log("Leaf: smash window - FAILED");
        return false;
    }
}
