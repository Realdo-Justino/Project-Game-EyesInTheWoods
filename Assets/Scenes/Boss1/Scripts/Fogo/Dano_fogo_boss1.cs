﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano_fogo_boss1 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Vida_personagem_principal Vida_personagem_principal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.gameObject.CompareTag("Player")){
            Vida_personagem_principal.receberDano(1);
        }
        
    }
}
