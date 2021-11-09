using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRock : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Rock;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    private void OnTriggerEnter2D(Collider2D colisor) {
        if((colisor.gameObject.tag=="Blast Zone")||(colisor.gameObject.tag=="Player")){
             Destroy(Rock);
        }
    }
}
