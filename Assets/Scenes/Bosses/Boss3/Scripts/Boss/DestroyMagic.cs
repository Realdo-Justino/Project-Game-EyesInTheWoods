using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMagic : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Magia;
    void Start()
    {
    }
    void Update(){
        Magia =this.gameObject;
    }
    public void Destroying(){
        Destroy(Magia);
    }
}
