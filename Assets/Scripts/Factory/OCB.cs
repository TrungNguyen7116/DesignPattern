using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCB : Bank
{
    public OCB()
    {
        bankName = "OCB";
    }
    public override void doSomething()
    {
        Debug.Log("OCB");
    }
}
