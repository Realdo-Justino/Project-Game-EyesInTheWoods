using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun : MonoBehaviour
{
    [SerializeField]Movimentacao Movimentacao;
    [SerializeField]Arma Arma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao.paralisado2= true;
        Arma.paralisado= false;
    }
}
