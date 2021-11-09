using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] float distance;
    [SerializeField] FlipEnemy FlipEnemy;
    [SerializeField] Transform groundCheck;
    public bool On=true;
    LayerMask mask;
    // Update is called once per frame
    void Start(){
        RepeatFind();
        mask = LayerMask.GetMask("Map");
    }
    void RepeatFind(){
        if(On==true){
            RaycastHit2D chao=Physics2D.Raycast(groundCheck.position, Vector2.down,distance,~mask);
            if(chao.collider==false){
                FlipEnemy.Flip();
            //Chamada de outra função que faz o inimigo virar 180 graus
            }
        }
        StartCoroutine(Timewaiter());
    }
    IEnumerator Timewaiter(){
        yield return new WaitForSeconds(0.1f);
        RepeatFind();
    }
}
