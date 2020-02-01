using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWallet
{
    void AddFunds();
    bool RequestFunds(int amount);
    int GetFunds();
}
