using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : ChildrenNode
{
    public override bool Execute()
    {
        for (int i = 0; i < children.Count; ++i)
        {
            if (children[i].Execute())
            {
                Debug.Log("Selector: return true");
                return true;
            }
        }
        Debug.Log("Selector: return false");
        return false;
    }
}
