using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endurance_Test : MonoBehaviour
{
    public Image endurance_bar;

    public float maxStamina = 100.0f; // ћаксимальна€ выносливость
    public float staminaRegenRate = 10.0f; // —корость восстановлени€ выносливости в секунду
    public float staminaConsumptionRate = 20.0f; // —корость расхода выносливости в секунду

    private float currentStamina;
    private bool canSprint = true;
    void Start()
    {
       endurance_bar = GetComponent<Image>();
        currentStamina = maxStamina;
    }

    
    void Update()
    {
        bool isShiftPressed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        if (isShiftPressed && currentStamina > 0)
        {
            // –асход выносливости при удержании "Shift"
            currentStamina -= staminaConsumptionRate * Time.deltaTime;
            
        }
        else 
        {
            // ¬осстановление выносливости
            currentStamina += staminaRegenRate * Time.deltaTime;
        }
        if (currentStamina <= 0)
        {
            canSprint = false;
        }
        else
        {
            canSprint = true;
        }
        // ќграничение выносливости в пределах [0, maxStamina]
        currentStamina = Mathf.Clamp(currentStamina, 0, maxStamina);
        endurance_bar.fillAmount = currentStamina / 100f;
    }
}
