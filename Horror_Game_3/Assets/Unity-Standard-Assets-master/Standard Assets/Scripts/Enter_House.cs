using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter_House : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player" && Count_Of_Keys.count == 5)
        {


        }



    }
    void Taking_All_Key()
    {
        switch (Count_Of_Keys.count)
        {
            case 5:

                break;
        }
    }
}
