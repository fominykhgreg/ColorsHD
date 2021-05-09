using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class two : MonoBehaviour
{
   


    // Start is called before the first frame update
    void timer(){
    SceneManager.LoadScene("scene3", LoadSceneMode.Single);
	}


    void Start()
    {
        Invoke("timer",7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
