using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    int displaytimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        this.GetComponent<Text>().text = Convert.ToString(displaytimer);
        if (displaytimer < 300)
        {
            // タイマーを増やす
            displaytimer++;
        }

    }

}
