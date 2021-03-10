using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{

    [SerializeField] Transform boxPosition;
    
    [SerializeField] float smoothVelocity = 0.5F;

    private Vector3 camVelocity = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 targetPosition = new Vector3(boxPosition.position.x, boxPosition.position.y + 2f, transform.position.z);

        
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref, camVelocity, smoothVelocity);
        
    }
}
