using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Text_4 : MonoBehaviour
{

    public static bool check_dead_man_1 = false;
    public float delay = 3.0f;
    private float timer = 0.0f;
    public static bool check_5 = false;


    public static Text text_5;

    void Start()
    {
        text_5 = GameObject.FindGameObjectWithTag("Text_5").GetComponent<Text>();
        HideObject();
    }

    // Update is called once per frame
    void Update()
    {
        switch (check_dead_man_1)
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
            switch (Change_Text_3.check_4_1)
            {
                case true:
                    OpenObject();
                    check_dead_man_1 = true;
                    Change_Text_3.check_4_1 = false;
                    //HideObject_1();
                    // Pass_Time();
                    break;

            }


        }
    }
    void HideObject()
    {
        text_5.enabled = false;

    }

    void OpenObject()
    {
        text_5.enabled = true;
    }
    void Pass_Time()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            HideObject();
            check_5 = true;
        }
    }
}
