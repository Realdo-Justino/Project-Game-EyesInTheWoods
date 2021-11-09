using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;

    [SerializeField] public bool Walking=false;
    [SerializeField] public bool Clawing=false;
    [SerializeField] public bool Jumping=false;
    [SerializeField] public bool ClawingJump=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Walking",Walking);
        anim.SetBool("Clawing",Clawing);
        anim.SetBool("Jumping",Jumping);
        anim.SetBool("Clawingjump",ClawingJump);
    }
}
