using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarUI : MonoBehaviour {

    static int starNbr = 0;
    TextMeshProUGUI starText;

    private void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
    }

    public void AddStar()
    {
        starNbr++;
        starText.text = "x " + starNbr;
    }
}
