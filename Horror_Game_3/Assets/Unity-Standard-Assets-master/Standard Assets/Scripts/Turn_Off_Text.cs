using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Off_Text : MonoBehaviour
{
    // Start is called before the first frame update
    public bool check_text = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            check_text = true;
        }
    }
}
