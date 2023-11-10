using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Count_Of_Keys : MonoBehaviour
{
    public Text count_keys;
    public int count = 0;
    public bool check_count = false;
    void Start()
    {
        count_keys = GameObject.FindGameObjectWithTag("count_of_key_1").GetComponent<Text>();
    }

    
    void Update()
    {
        count_keys.text = Convert.ToString(count);
        Check_Count();
    }
    void Check_Count()
    {
        if (count == 5)
        {
            check_count = true;
        }
    }
}
