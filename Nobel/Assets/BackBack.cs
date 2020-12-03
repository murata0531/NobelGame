using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utage;

public class BackBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //public void OnClick()
        //{
        //SceneManager.LoadScene ("SampleScene");
       // }

       
    }

    public void buttonpush()
    {
       SceneManager.LoadScene ("SampleScene"); 
    }
  
}