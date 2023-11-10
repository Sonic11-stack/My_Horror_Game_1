using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreamerActive : MonoBehaviour {
	public GameObject monstr;

    GameObject image;
    GameObject strip;

    //public bool check_text = false;

    Text endurance;

    [SerializeField] private Change_Text_5 change_text_5;

    //[SerializeField] private Turn_On_Keys turn_on_keys;

    
    void Start()
    {
        image = GameObject.FindWithTag("image");
        strip = GameObject.FindWithTag("strip");

        endurance = GameObject.FindGameObjectWithTag("endurance").GetComponent<Text>();

        
    }
    void  OnTriggerStay ( Collider other  ){
        if (other.tag == "Player")
        {
            monstr.active = true;
            image.SetActive(false);
            strip.SetActive(false);
            endurance.enabled = false;
            //check_text = true;
            //change_text_5.text_6.enabled = false;

            
            //turn_on_keys.find_key.enabled = false;
            //turn_on_keys.count_of_keys.enabled = false;
            //turn_on_keys.count_of_keys_1.enabled = false;


        }
	}
}