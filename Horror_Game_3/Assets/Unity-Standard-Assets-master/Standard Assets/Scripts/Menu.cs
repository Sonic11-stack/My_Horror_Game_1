using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Open_Main_Game()
    {
        SceneManager.LoadScene("Main_Scene");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void Close_Game()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
}
