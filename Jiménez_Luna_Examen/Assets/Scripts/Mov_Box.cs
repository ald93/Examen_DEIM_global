using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_box : MonoBehaviour
{

    [SerializeField] float velocidad;

    private float desplX;

    private float desplY;

   


    // Start is called before the first frame update
    void Start()
    {

        velocidad = 25f;
        
    }

    // Update is called once per frame
    void Update()
    {

        desplX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * desplX * Time.deltaTime * velocidad);

        transform.Translate(Vector3.left * desplY * Time.deltaTime * velocidad);


        
    }
}
