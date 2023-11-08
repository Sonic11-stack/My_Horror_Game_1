using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Monster : MonoBehaviour
{
    GameObject high_monster;
    void Start()
    {
        high_monster = GameObject.FindWithTag("Enemy");
        high_monster.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Turn_On_Monster()
    {

    }
}
