using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_1 : MonoBehaviour
{
    
     Animator Animation1;
   
    // Start is called before the first frame update
    void Start()
    {
        Animation1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Animation1.SetTrigger("Active");
        }
    }
}
