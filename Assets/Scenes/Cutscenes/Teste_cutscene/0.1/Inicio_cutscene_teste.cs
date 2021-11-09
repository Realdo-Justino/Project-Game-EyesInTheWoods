using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio_cutscene_teste : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Movimentacao  Movimentacao;

    
  public Animator camAnim;
    void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.gameObject.CompareTag("Player")){
            Movimentacao.paralisado2= true;
            camAnim.SetBool("Cutscene1",true);
            Invoke(nameof(StopCutscene),2f);
        }
    }
    void StopCutscene(){
        camAnim.SetBool("Cutscene1",false);
        Movimentacao.paralisado2= false;
        Destroy(gameObject);
    }
}
