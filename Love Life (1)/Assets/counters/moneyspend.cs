using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyspend : MonoBehaviour
{
    public float value;

    public money moneyscript;

    public void Buy()
    {
        if(moneyscript.Money >= value)
        {
            Debug.Log("buy.");
            moneyscript.Money -= value;
            moneyscript.Save();
        }
        else
        {
            Debug.Log("Failed not enough money");
        }
    }
}
