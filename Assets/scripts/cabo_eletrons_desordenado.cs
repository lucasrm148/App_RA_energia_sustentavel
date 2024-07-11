using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabo_eletrons_desordenado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void remove_wall() {
        var lateral1 = GetComponentInChildren<cabo_eletrons_desordenado>();
        Debug.Log(lateral1.GetType());
    
    }
}
