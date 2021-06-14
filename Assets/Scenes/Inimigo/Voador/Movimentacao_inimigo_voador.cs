using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao_inimigo_voador : MonoBehaviour
{
    // Start is called before the first frame update
    //Declaração da distancia que é feita do groundcheck para frente

    public bool ladoD;

    //Preparando uma variavel pra chamr outra função

    //Criação de um "vetor3" que adquiri os valores do objeto
    private void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        lado();
    }
    void lado(){
        if(ladoD==true){
                transform.eulerAngles= new Vector3(0,0,0);
        }else{
                transform.eulerAngles= new Vector3(0,180,0);
        }
    }
    
}
