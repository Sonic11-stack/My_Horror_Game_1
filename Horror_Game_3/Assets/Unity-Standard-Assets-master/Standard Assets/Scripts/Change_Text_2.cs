using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Text_2 : MonoBehaviour
{
    //public float delay = 3.0f;
    //private float timer = 0.0f;
    public static bool shouldHide_2 = false;
    //public GameObject house;
    public static bool check_2 = true;

    public static Text text_2;



    void Start()
    {
        text_2 = GameObject.FindGameObjectWithTag("Text_2").GetComponent<Text>();
        //house = GetComponent<GameObject>();
        HideObject();
    }



    void Update()
    {

        switch (Change_Text_1.shouldHide_1)
        {

            case true:
                //OpenObject();
                Checking();
                if (check_2 == false)
                    HideObject();
                 //shouldHide_2 = true;
                //Change_Text_1.shouldHide_1 = false;
                break;
            
        }


    }
   /* void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            HideObject();
        }
    } */
    public void HideObject()
    {
        text_2.enabled = false;
    }
    void OpenObject()
    {
        text_2.enabled = true;
    }
    void Checking()
    {
        switch (check_2)
        {
            case true:
                OpenObject();
                break;
        }
    }
}
