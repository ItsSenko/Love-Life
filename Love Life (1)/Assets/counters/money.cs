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
    }

    private void Start()
    {
        Load();
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("Money", Money);
    }

    public void Load()
    {
        Money = PlayerPrefs.GetFloat("Money");
    }
}
