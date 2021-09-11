using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    public BankButton[] button;


    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            button[i].InitializeButton(BankFactory.Createbank((EnumBank)i));
        }
    }
}
