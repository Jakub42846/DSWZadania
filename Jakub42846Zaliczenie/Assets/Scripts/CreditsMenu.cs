using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour
{
    public TMPro.TMP_Text text;
    string value;
    public Credit Credits;
    void Start()
    {
        for(int i = 0; i < Credits.opis.Length; i++)
        {
            value = value + Credits.opis[i] + "\n";
        }

        text.SetText(value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
