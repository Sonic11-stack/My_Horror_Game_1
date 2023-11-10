using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Game : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scene_1;
    void Start()
    {
        //scene_1 = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
      /*  switch(Return_To_Menu.check_return)
        {
            case true:
                SceneManager.LoadScene(scene_1, LoadSceneMode.Single);
                break;
        } */
        //int scene = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetKeyDown(KeyCode.F))
        //SceneManager.LoadScene("Menu");
        //SceneManager.LoadScene("Main_Scene");
        //SceneReloader.ReloadLevel(1); 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            //check_return = true;
            //int scene = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(Restart_Game.scene_1, LoadSceneMode.Single);
            //Restart_Game.scene_1;
        }
    }

}
