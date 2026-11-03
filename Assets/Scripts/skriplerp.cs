using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class skriplerp : MonoBehaviour
{
    float data1;
    float data2;
    float data3;
    // Start is called before the first frame update
    void Start()
    {
        data1 = 1.5f;
        data2 = 4.5f;

        Debug.Log(jumlah(20, 5, 30));
    }

    private void OnMouseDown()
    {
        Debug.Log(" mouse di klik ");
    }

    private void OnMouseUp()
    {
        Debug.Log(" mouse di lepas");
    }

    private void OnMouseOver()
    {
        Debug.Log(" mouse di atas objek");
    }

    float jumlah(float A, float B, float C) 
    {
        data3 =A+B+C;

        return data3;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
