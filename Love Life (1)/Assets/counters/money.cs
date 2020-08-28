using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class money : MonoBehaviour
{
    public string moneydisplay;
    public float Money = 1000f;
    public TextMeshProUGUI text;

    public void Update()
    {
        moneydisplay = "¥ " + Money.ToString();
        text.SetText(moneydisplay);

        if (Input.GetKeyDown(KeyCode.Equals))
        {
            Money += 50f;
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            Money -= 50f;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.SetFloat("Money", Money);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Money = PlayerPrefs.GetFloat("Money");
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Money = 1000f;
        }
    }
}
