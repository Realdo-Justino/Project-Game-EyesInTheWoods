using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmDamage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vida_personagem_principal Vida_personagem_principal;
    [SerializeField] LifeEnemy1 LifeEnemy1;
     void OnTriggerEnter2D(Collider2D colisor) {
        if(this.enabled==true){
            if(colisor.gameObject.tag=="Player"){
                Vida_personagem_principal.receberDano(1);
            }
            if(colisor.gameObject.tag=="ProjeteisFortes"){
                LifeEnemy1.receberDano(5);
            }
            if(colisor.gameObject.tag=="Projeteis"){
                LifeEnemy1.receberDano(1);
            }
        }
    }
}
