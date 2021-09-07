using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class menadzerpkt : MonoBehaviour
{
    public int punkty;
    public TextMeshProUGUI pktinter;

    private void Update()
    {
        
    }

    public void DodajPunkt()
    {
        punkty++;
        pktinter.text = punkty.ToString();

    }
}
