using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildrenNode : Node
{

    public List<Node> children = new List<Node>();

    public override bool Execute()
    {
        throw new NotImplementedException();
    }
}
