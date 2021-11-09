using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_de_Vida : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public int vida;

    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        anim.SetInteger("Vida",vida);
    }
}
