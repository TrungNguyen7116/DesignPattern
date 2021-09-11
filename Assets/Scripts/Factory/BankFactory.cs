using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankFactory : MonoBehaviour
{
    public static Bank Createbank(EnumBank type)
    {
        switch(type)
        {
            case EnumBank.VIETCOMBANK:
                return new Vietcombank();
            case EnumBank.OCB:
                return new OCB();
            case EnumBank.AGRIBANK:
                return new Agribank();
            default:
                return new Bank();
        }
    }
}
