using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipStage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]Fim_da_fase Fim_da_fase;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            Fim_da_fase.Finish();
        }
    }
}
