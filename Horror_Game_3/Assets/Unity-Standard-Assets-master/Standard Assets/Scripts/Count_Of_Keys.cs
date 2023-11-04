using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Count_Of_Keys : MonoBehaviour
{
    public Text count_keys;
    public static int count = 0;
    void Start()
    {
        count_keys = GameObject.FindGameObjectWithTag("count_key").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        count_keys.text = Convert.ToString(count);
    }
}
