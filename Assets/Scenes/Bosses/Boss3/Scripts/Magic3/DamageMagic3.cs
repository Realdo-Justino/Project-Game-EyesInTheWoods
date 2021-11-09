using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMagic3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vida_personagem_principal Vida_personagem_principal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.tag=="Player"){
            Vida_personagem_principal.receberDano(1);
        }
    }
}
