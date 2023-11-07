using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Text_2 : MonoBehaviour
{
    //public float delay = 3.0f;
    //private float timer = 0.0f;
    public static bool shouldHide_2 = false;

    public Text text_2;



    void Start()
    {
        text_2 = GameObject.FindGameObjectWithTag("Text_2").GetComponent<Text>();
        HideObject();
    }



    void Update()
    {

        switch (Change_Text_1.shouldHide_1)
        {

            case true:
                OpenObject();
                
                break;
        } 



    }
    void HideObject()
    {
        text_2.enabled = false;
    }
    void OpenObject()
    {
        text_2.enabled = true;
    }
}
