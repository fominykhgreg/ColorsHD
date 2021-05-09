using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
   
   //string[] array2 = new string[] { "scene1", "scene2", "scene3", "scene4", "scene5","scene6","scene7" };
    // Start is called before the first frame update\

   
//string[] malePetNames = { "scene1", "scene2", "scene3", "scene4", "scene5","scene6","scene7" };
 

  public void run(){
   SceneManager.LoadScene("scene1", LoadSceneMode.Single);
 }

    void timer(){
      SceneManager.LoadScene("scene1", LoadSceneMode.Single);
	}


    void Start()
    {
        //Invoke("timer",15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
