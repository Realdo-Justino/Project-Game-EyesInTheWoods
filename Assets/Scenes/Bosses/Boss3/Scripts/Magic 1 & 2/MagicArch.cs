using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicArch : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;

    public float d;
    void Start()
    {
        rb.AddForce(new Vector2(d,525f), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
