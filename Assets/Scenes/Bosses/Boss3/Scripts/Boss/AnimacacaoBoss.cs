using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacacaoBoss : MonoBehaviour
{
    [SerializeField]Animator Animin;
    [SerializeField]bool Magic=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextSprites(){
        Animin.SetBool("Magicing",Magic);
        Magic= !Magic;
    }
}
