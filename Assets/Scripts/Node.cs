using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node
{

    public Node parent;

    public abstract bool Execute();
}
