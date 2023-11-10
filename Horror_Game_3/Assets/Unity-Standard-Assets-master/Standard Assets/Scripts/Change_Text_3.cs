using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Text_3 : MonoBehaviour
{

    public float delay = 3.0f;
    private float timer_1 = 0.0f;
    public  bool shouldHide_4 = false;
    public  bool check_4 = true;

    public  bool check_4_1 = true;

    public Text text_4;

    [SerializeField] private Find_House find_house;

    void Start()
    {
        text_4 = GameObject.FindGameObjectWithTag("Text_4").GetComponent<Text>();
        HideObject();

    }



    void Update()
    {
        switch(check_4_1)
        {
            case true:
                Found_House();
                break;
            case false:
                HideObject();
                break;
        }
       
        //check_4 = true;
        
        


    }
    void HideObject()
    {
        text_4.enabled = false;
    }

    void OpenObject()
    {
        text_4.enabled = true;
    }
    void Checking()
    {
        switch (check_4)
        {
            case true:
                OpenObject();
                break;
        }
    }
    void Found_House()
    {
        switch (find_house.check_house_1 && find_house.check_3)
        {

            case true:
                
                Checking();
                
                // timer_1 += Time.deltaTime;

               /*  if (timer_1 >= delay && !shouldHide_4)
                {
                    check_4 = false;
                    HideObject();
                    shouldHide_4 = true;

                } */
                


                break;
        }
    }
}
