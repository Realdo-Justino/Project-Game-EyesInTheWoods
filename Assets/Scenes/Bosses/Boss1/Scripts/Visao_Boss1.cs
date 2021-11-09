using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao_Boss1 : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    Transform inimigo;

    [SerializeField]
    Boss1_padrao1 Boss1_padrao1;

    [SerializeField]
    Charge_boss1 Charge_boss1;

    bool estado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null){
            float distanciaPlayer=Vector2.Distance(inimigo.position,player.position);
            if(transform.position.x<=player.position.x){
                estado=true;
            }
            else{
                estado=false;
            }
            Boss1_padrao1.visao_boss=estado;
            Charge_boss1.visao_boss=estado;
        }
    }
}
