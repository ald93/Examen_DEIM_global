using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caen_huevos : MonoBehaviour
{
    [SerializeField] GameObject Huevo;

    [SerializeField] Transform initPos;

    Vector3 newPosY;

    [SerializeField] GameObject huevo_recogido;

    [SerializeField] MeshRenderer myMesh;


    // Start is called before the first frame update
    void Start()
    {

        CrearHuevo();



    }

    // Update is called once per frame
    void Update()
    {

    }

    void CrearHuevo()
    {
        for (int n = 0; n < 25; n++)
        {
            float randomPosY = Random.Range(0f, 25f);

            Vector3 desplazarPosY = new Vector3(0, randomPosY, 2 * n);


            newPosY = initPos.position;

            Instantiate(Huevo, newPosY, Quaternion.identity);




        }





    }

    
   
    

     void OnTriggerEnter (Collider other)

{
      Destroy(huevo_recogido);
}


}
