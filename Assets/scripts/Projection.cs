using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projection : MonoBehaviour
{
    string target_name;
    bool var_start = false;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //target.SetActive(false);
    }

    // Update is called once per frame
    void Update(){

    }
    public  void _start_target() {
        Debug.Log("superfice detectada");
        target.SetActive(true);
    }
}
