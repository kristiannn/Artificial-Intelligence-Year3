using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : ChildrenNode
{
    public override bool Execute()
    {
        for (int i = 0; i < children.Count; ++i)
        {
            if (!children[i].Execute())
            {
                Debug.Log("Sequence: return false");
                return false;
            }
        }
        Debug.Log("Sequence: return true");
        return true;
    }
}
