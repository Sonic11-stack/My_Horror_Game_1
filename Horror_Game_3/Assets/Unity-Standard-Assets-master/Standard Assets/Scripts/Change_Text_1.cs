using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.UI;

public class Change_Text_1 : MonoBehaviour
{
    public float delay = 3.0f;
    private float timer_1 = 0.0f;
    public  bool shouldHide_1 = false;
    public bool check_1 = true;
    [SerializeField] private Change_Text change_text;

    public Text text_1;



    void Start()
    {
        text_1 = GameObject.FindGameObjectWithTag("Text_1").GetComponent<Text>();
        HideObject();
        
    }


    
    void Update()
    {
        
        switch (change_text.shouldHide)//(Change_Text.shouldHide)
        {
            
            case true:
                //if(check_1 == true) 
                    //OpenObject();
                Checking();
                //check = false;
                timer_1 += Time.deltaTime;

                if (timer_1 >= delay && !shouldHide_1)
                {
                    check_1 = false;
                    HideObject();
                    shouldHide_1 = true;
                    //Change_Text.shouldHide = false;
                }
                else
                {
                    //OpenObject();
                }
                
               
                break;
        }


        
    }
    void HideObject()
    {
        text_1.enabled = false;
    }
    
    void OpenObject()
    {
        text_1.enabled = true;
    }
    void Checking()
    {
        switch(check_1)
        {
            case true:
                OpenObject();
                break;
        }
    }
}