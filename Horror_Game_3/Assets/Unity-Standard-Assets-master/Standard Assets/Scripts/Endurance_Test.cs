using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using static UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController;

public class Endurance_Test : MonoBehaviour
{
    public Image endurance_bar;

    public float maxStamina = 100.0f; // ������������ ������������
    public float staminaRegenRate = 10.0f; // �������� �������������� ������������ � �������
    public float staminaConsumptionRate = 20.0f; // �������� ������� ������������ � �������

    public float currentStamina;
    private bool canSprint = true;

    [SerializeField] private FirstPersonController controller;
    void Start()
    {
       endurance_bar = GetComponent<Image>();
        currentStamina = maxStamina;
    }

    
    void Update()
    {
        bool isShiftPressed = Input.GetKey(KeyCode.LeftShift);
        

        if (isShiftPressed && currentStamina > 0)
        {
            // ������ ������������ ��� ��������� "Shift"
            currentStamina -= staminaConsumptionRate * Time.deltaTime;
            //controller.GetInput(10);
            
            //CurrentTargetSpeed *= RunMultiplier;
        }
        
        else 
        {
            // �������������� ������������
            
            currentStamina += staminaRegenRate * Time.deltaTime;
            
        }
        
       /* if (currentStamina <= 0)
        {
            canSprint = false;
        }
        else
        {
            canSprint = true;
        } */
        // ����������� ������������ � �������� [0, maxStamina]
        currentStamina = Mathf.Clamp(currentStamina, 0, maxStamina);
        endurance_bar.fillAmount = currentStamina / 100f;
    }
}
