using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agribank : Bank
{
    public Agribank()
    {
        bankName = "Agribank";
    }
    public override void doSomething()
    {
        Debug.Log("Agribank");
    }
}
