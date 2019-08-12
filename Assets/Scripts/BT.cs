using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT : MonoBehaviour {

    public Selector root;

	// Use this for initialization
	void Start () {
        BehaviorTree();
        root.Execute();
        //nodes always return the value in Node.cs (return false/true) - no matter the result of selector/sequence nodes???
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void BehaviorTree()
    {
        root = new Selector();

        //First two sequences
        Sequence sequenceLeft = new Sequence();
        sequenceLeft.parent = root;
        root.children.Add(sequenceLeft);

        Sequence sequenceRight = new Sequence();
        sequenceRight.parent = root;
        root.children.Add(sequenceRight);



        //Left sequence
        WalkToDoor walkToDoor = new WalkToDoor();
        walkToDoor.success = false;
        walkToDoor.parent = sequenceLeft;
        sequenceLeft.children.Add(walkToDoor);

        Selector selectorLeft = new Selector();
        selectorLeft.parent = sequenceLeft;
        sequenceLeft.children.Add(selectorLeft);

        WalkThroughDoor walkThroughDoor = new WalkThroughDoor();
        walkThroughDoor.success = true;
        walkThroughDoor.parent = sequenceLeft;
        sequenceLeft.children.Add(walkThroughDoor);

        CloseDoor closeDoor = new CloseDoor();
        closeDoor.success = true;
        closeDoor.parent = sequenceLeft;
        sequenceLeft.children.Add(closeDoor);

        //Selector Left
        OpenDoor openDoor = new OpenDoor();
        openDoor.success = false;
        openDoor.parent = selectorLeft;
        selectorLeft.children.Add(openDoor);

        Sequence sequenceLeftTwo = new Sequence();
        sequenceLeftTwo.parent = selectorLeft;
        selectorLeft.children.Add(sequenceLeftTwo);

        SmashDoor smashDoor = new SmashDoor();
        smashDoor.success = true;
        smashDoor.parent = selectorLeft;
        selectorLeft.children.Add(smashDoor);

        //Sequence Left Two
        UnlockDoor unlockDoor = new UnlockDoor();
        unlockDoor.success = false;
        unlockDoor.parent = sequenceLeftTwo;
        sequenceLeftTwo.children.Add(unlockDoor);

        OpenDoor openDoor2 = new OpenDoor();
        openDoor2.success = true;
        openDoor2.parent = sequenceLeftTwo;
        sequenceLeftTwo.children.Add(openDoor2);




        //Right Sequence
        WalkToWindow walkToWindow = new WalkToWindow();
        walkToWindow.success = true;
        walkToWindow.parent = sequenceRight;
        sequenceRight.children.Add(walkToWindow);

        Selector selectorRight = new Selector();
        selectorRight.parent = sequenceRight;
        sequenceRight.children.Add(selectorRight);

        ClimbThroughWindow climbThroughWindow = new ClimbThroughWindow();
        climbThroughWindow.success = true;
        climbThroughWindow.parent = sequenceRight;
        sequenceRight.children.Add(climbThroughWindow);

        CloseWindow closeWindow = new CloseWindow();
        closeWindow.success = true;
        closeWindow.parent = sequenceRight;
        sequenceRight.children.Add(closeWindow);


        //Selector Right
        OpenWindow openWindow = new OpenWindow();
        openWindow.success = false;
        openWindow.parent = selectorRight;
        selectorRight.children.Add(openWindow);

        Sequence sequenceRightTwo = new Sequence();
        sequenceRightTwo.parent = selectorRight;
        selectorRight.children.Add(sequenceRightTwo);

        SmashWindow smashWindow = new SmashWindow();
        smashWindow.success = true;
        smashWindow.parent = selectorRight;
        selectorRight.children.Add(smashWindow);


        //Sequence Right Two
        UnlockWindow unlockWindow = new UnlockWindow();
        unlockWindow.success = true;
        unlockWindow.parent = sequenceRightTwo;
        sequenceRightTwo.children.Add(unlockWindow);

        OpenWindow openWindow2 = new OpenWindow();
        openWindow2.success = true;
        openWindow2.parent = sequenceRightTwo;
        sequenceRightTwo.children.Add(openWindow2);
        

    }
}
