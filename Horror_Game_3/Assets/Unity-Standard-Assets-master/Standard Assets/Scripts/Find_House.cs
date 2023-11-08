using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class Find_House : MonoBehaviour
{
    public static bool check_house_1 = false;
    public float delay = 3.0f;
    private float timer = 0.0f;
    public  static bool check_3 = false;
   

    public Text text_3;

    void Start()
    {
        text_3 = GameObject.FindGameObjectWithTag("Text_3").GetComponent<Text>();
        HideObject();
    }

    // Update is called once per frame
    void Update()
    {
        switch (check_house_1)
        {
            case true:
                Pass_Time();
                break;
        }
     }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            switch(Change_Text_2.check_2)
            {
                case true:
                    OpenObject();
                    check_house_1 = true;
                    Change_Text_2.check_2 = false;
                    //HideObject_1();
                   // Pass_Time();
                    break;
                
            }
            

        }
    }
    void HideObject()
    {
        text_3.enabled = false;
        
    }
   
    void OpenObject()
    {
        text_3.enabled = true;
    }
    void Pass_Time()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            HideObject();
            check_3 = true;
        }
    }
}
