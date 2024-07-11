using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Detection_Scene : MonoBehaviour
{   
    ImageTargetBehaviour target = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void get_target(ImageTargetBehaviour target)
    { 
        this.target = target;
        Debug.Log(target.name);
    }
    public String send_target()
    { 
        return target.name;
    }
    
}
