using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankButton : MonoBehaviour
{
    private Bank myBank;

    public Text nameButton;

    public void InitializeButton(Bank target)
    {
        myBank = target;
        nameButton.text = myBank.bankName;
    }

    public void GetButton()
    {
        myBank.doSomething();
    }
}
