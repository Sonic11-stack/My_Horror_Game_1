using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Key_1 : MonoBehaviour
{
    // Start is called before the first frame update
    //GameObject key_1 = new GameObject();
    void Start()
    {
        //key_1 = GameObject.FindWithTag("key_1");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // ���������, ��� ������, � ������� ��������� ������������, �������� �������
            // ���� ��, �� �������� ���� ������
            gameObject.SetActive(false);
        }
    }
}
