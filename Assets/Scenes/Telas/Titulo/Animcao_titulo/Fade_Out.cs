using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Out : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;

    public bool exiting;
    void Start()
    {
        anim.SetBool("Exiting",true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}