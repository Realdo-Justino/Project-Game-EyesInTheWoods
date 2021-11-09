using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform Enemy;

    public void Flip(){
        Debug.Log(Enemy.rotation.y);
        switch(Enemy.rotation.y){
            case 0: FlipLeft();
            break;
            case -1: FlipRight();
            break;
            default: Debug.Log("Ocorreu um erro");
            break;
        }
    }
    public void FlipLeft(){
        transform.eulerAngles= new Vector3(0,180,0);
    }
    public void FlipRight(){
        transform.eulerAngles= new Vector3(0,0,0);
    }
}
