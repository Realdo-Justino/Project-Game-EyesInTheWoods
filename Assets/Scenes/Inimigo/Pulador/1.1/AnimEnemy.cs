using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        anim=GetComponent<Animator>();
    }
    void OnCollisionExit2D(Collision2D colisor) 
    {
        if(colisor.gameObject.layer==8){
            anim.SetBool("Pulando",true);
        }
    }
    void OnCollisionEnter2D(Collision2D colisor) 
    {
        if(colisor.gameObject.layer==8){
            anim.SetBool("Pulando",false);
        }
    }
}
