using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] BoxCollider2D boxCollider2D;
    [SerializeField] DownwordAtk DownwordAtk;
    public bool restart = false;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(restart==true){
            boxCollider2D.isTrigger=true;
        }else{
            boxCollider2D.isTrigger=false;
        }
    }
    public void Activate(){
        boxCollider2D.isTrigger=false;
    }
}
