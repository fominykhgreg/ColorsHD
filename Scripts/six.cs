using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class six : MonoBehaviour
{
   


    // Start is called before the first frame update
    void timer(){
    SceneManager.LoadScene("scene7", LoadSceneMode.Single);
	}


    void Start()
    {
        Invoke("timer",8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
