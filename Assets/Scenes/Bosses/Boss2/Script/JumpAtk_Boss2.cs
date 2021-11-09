using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAtk_Boss2 : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] public bool DoOnce;
    [SerializeField] public bool LadoE;
    [SerializeField] Transform player;
    

    [SerializeField] public float Distancia;
    // Start is called before the first frame update
    void Start()
    {
        DoOnce=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(DoOnce==true){
            Lado();
            rigidBody.AddForce(new Vector2(Distancia,70f), ForceMode2D.Impulse);
            DoOnce=false;
        }
    }
    public void Lado(){
        if(player!=null){
            if(transform.position.x<player.position.x){
                LadoE=true;
            }
            else{
                LadoE=false;
            }
            switch(LadoE){
                case true:
                    transform.eulerAngles= new Vector3(0,0,0);
                    Distancia=8;
                    break;
                case false:
                    transform.eulerAngles= new Vector3(0,180,0);
                    Distancia=-8;
                    break;
            }
        }
    }
}
