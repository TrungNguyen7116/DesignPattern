using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vietcombank : Bank
{
    public Vietcombank()
    {
        bankName = "Vietcombank";
    }
    public override void doSomething()
    {
        Debug.Log("Vietcombank");
    }
}
