using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    private float speed = -1f;
    private float lowerY = -11.39f;
    private float upperY = 22.78f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() {
        transform.Translate(0f, speed * Time.deltaTime, 0f);

        if (transform.position.y <= lowerY)
            transform.Translate(0f, upperY, 0f);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
