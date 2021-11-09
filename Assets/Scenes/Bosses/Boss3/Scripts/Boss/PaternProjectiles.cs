using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaternProjectiles : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]Magic1 Magic1;
    [SerializeField]SpawMagic4 SpawMagic4;
    [SerializeField]SpawnMagic3 SpawnMagic3;
    [SerializeField]Magic5 Magic5;
    [SerializeField]CountClones CountClones;
    [SerializeField]AnimacacaoBoss AnimacacaoBoss;
    public bool Doing=false;
    void Start()
    {
        RandomNumber();
        Doing=false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void RandomNumber(){
        if(Doing == true){

        }else{
            Anim();
            var numero= Random.Range(1.0f, 4.999f);
            int Inumero=Mathf.RoundToInt(numero);
            Debug.Log(Inumero);
            switch(Inumero){
                case 1: Magic1.RandomNumber();
                break;
                case 2: SpawnMagic3.SpawnAtk();
                break;
                case 3: SpawMagic4.SpawnAtk();
                break;
                case 4: Magic5.RandomNumber();
                break;
                default: RandomNumber();
                break;
            }
            Anim();   
        }
        
        //StartCoroutine(Waiting(numero));  
    }
    void Anim(){
        AnimacacaoBoss.NextSprites();
    }
}
