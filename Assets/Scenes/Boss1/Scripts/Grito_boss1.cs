﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grito_boss1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform player;

    [SerializeField]
    Movimentacao Movimentacao;

    [SerializeField]
    float alcance_grito;

    [SerializeField]
    public bool fazer_uma_vez=true;

    void Start()
    {
        alcance_grito=transform.position.x+30;
            if(alcance_grito>=player.position.x){
                Movimentacao.paralisado=true;
            }
            else{
                
            }
            fazer_uma_vez=false;
        Debug.Log("oi");
    }

    // Update is called once per frame
    void Update()
    {   
        if(fazer_uma_vez==true){
        }
    }
    
}
