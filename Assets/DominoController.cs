using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoController : MonoBehaviour
{
    public GameObject prefabPieza;
    public Transform lanzadorPieza;
    const float deltaZ = 0.025f;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 pos = lanzadorPieza.transform.position + new Vector3(0,0, deltaZ);

        //Vector3 newPos = new Vector3(lanzadorPieza.transform.position.x, lanzadorPieza.transform.position.y, lanzadorPieza.transform.position.z);
        
        for (int i = 0; i < 25;i++)
        {
            Instantiate(prefabPieza, lanzadorPieza.transform.position, lanzadorPieza.transform.rotation);
            lanzadorPieza.transform.position += new Vector3(0, 0, deltaZ);


        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
