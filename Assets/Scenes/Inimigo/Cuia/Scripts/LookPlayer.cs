using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null){
            if(transform.position.x<=player.position.x){
                transform.eulerAngles=new Vector2(0f,0f);
            }
            else{
                transform.eulerAngles=new Vector2(0f,180f);
            }
        }
    }
}
