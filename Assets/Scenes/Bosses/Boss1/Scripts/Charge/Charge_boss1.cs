using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge_boss1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool charge;
    public bool visao_boss;

    [SerializeField]
    public bool FazerUmaVez=false;

    [SerializeField]
    float lado_charge;

    [SerializeField]
    Boss1_padrao1 Boss1_padrao1;

    private Rigidbody2D rig;
    
    void Start()
    {
         rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            if(FazerUmaVez==false){
                lado();
                rig.AddForce(new Vector2(lado_charge,0f), ForceMode2D.Impulse);
                Boss1_padrao1.charging=true;
                Boss1_padrao1.contador=0;
            }
    }
    public void lado(){
        if(visao_boss==true){
            transform.eulerAngles=new Vector2(0f,0f);
            lado_charge=220f;
        }
        else{
            transform.eulerAngles=new Vector2(0f,180f);
            lado_charge=-220f;
        }
        FazerUmaVez=true;
    }
}
