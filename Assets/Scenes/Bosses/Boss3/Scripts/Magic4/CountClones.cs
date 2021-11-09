using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountClones : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PaternProjectiles PaternProjectiles;
    void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    public void DeleteComplete(){
            PaternProjectiles.RandomNumber();    
            PaternProjectiles.Doing=true;
            
    }
}
