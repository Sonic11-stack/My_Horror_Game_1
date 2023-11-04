using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Key_2 : MonoBehaviour
{
    void Start()
    {

    }



    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {

            Destroy(this.gameObject);
            Count_Of_Keys.count++;

        }
    }
}
