using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Utility;

public class Return_To_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool check_return = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Return_Menu()
    {
        
        //SceneManager.LoadScene("Menu");
        //SceneManager.LoadScene("Main_Scene");
        //SceneReloader.ReloadLevel(1); 
        
            SceneManager.LoadScene("Menu");
            //int scene = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(Restart_Game.scene_1, LoadSceneMode.Single);
            //Restart_Game.scene_1;
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
