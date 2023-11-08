using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Turn_On_Keys : MonoBehaviour
{
     GameObject key_1;
     GameObject key_2;
     GameObject key_3;
     GameObject key_4;
     GameObject key_5;

    Text find_key;
    Text count_of_keys;
    Text count_of_keys_1;

    void Start()
    {
        key_1 = GameObject.FindWithTag("key_1");
        key_2 = GameObject.FindWithTag("key_2");
        key_3 = GameObject.FindWithTag("key_3");
        key_4 = GameObject.FindWithTag("key_4");
        key_5 = GameObject.FindWithTag("key_5");

        key_1.SetActive(false);
        key_2.SetActive(false);
        key_3.SetActive(false);
        key_4.SetActive(false);
        key_5.SetActive(false);

        find_key = GameObject.FindGameObjectWithTag("find_key").GetComponent<Text>();
        count_of_keys = GameObject.FindGameObjectWithTag("count_of_key").GetComponent<Text>();
        count_of_keys_1 = GameObject.FindGameObjectWithTag("count_of_key_1").GetComponent<Text>();

        HideObject();
    }

    
    void Update()
    {
        Turn_On_Of_Keys();
    }
    void Turn_On_Of_Keys()
    {
        switch(Change_Text_3.check_4_1)
        {
            case false:
                OpenObject();
                if(GameObject.FindWithTag("key_1") == null)
                {
                    key_1.SetActive(true);
                    key_2.SetActive(true);
                    key_3.SetActive(true);
                    key_4.SetActive(true);
                    key_5.SetActive(true);
                }
                break;
        }
    }
    void HideObject()
    {
        find_key.enabled = false;
        count_of_keys.enabled = false;
        count_of_keys_1.enabled = false;
    }

    void OpenObject()
    {
        find_key.enabled = true;
        count_of_keys.enabled = true;
        count_of_keys_1.enabled = true;
    }
}
