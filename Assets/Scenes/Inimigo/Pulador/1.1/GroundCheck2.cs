using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] FlipEnemy FlipEnemy; 
    public bool On=true;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(On==true){
            if(other.tag !="Plataformas"){
                FlipEnemy.Flip();
            }
        }
    }
}
