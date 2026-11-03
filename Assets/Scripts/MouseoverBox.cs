using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseoverBox : MonoBehaviour
{
    float kecepatan = 5f;
    bool sedangmouseover;
    Vector3 skalabesar;
    bool sudahdatang;
    public AudioSource suaraefek;
    // Start is called before the first frame update
    void Start()
    {
       sedangmouseover = false;
       sudahdatang = false;
       skalabesar.x = 1.8f;
       skalabesar.y = 2f;
       skalabesar.z = 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
        if (sedangmouseover)
        {
            this.gameObject.transform.localScale =
                Vector3.Lerp(this.gameObject.transform.localScale, skalabesar, Time.deltaTime * kecepatan);
            
        }
        if (!sedangmouseover)
        {
            this.gameObject.transform.localScale =
                Vector3.Lerp(this.gameObject.transform.localScale, Vector3.one, Time.deltaTime * kecepatan);
        }
    }

    private void OnMouseOver()
    {
        if (!sudahdatang) //artinya sudahdatang==false
        {
            sedangmouseover = true;
            sudahdatang = true;
            if (!suaraefek.isPlaying)
            {
                suaraefek.Play();
            }
        }
        

    }

    private void OnMouseExit()
    {
        if (sudahdatang)
        {
            sudahdatang = false;
            sedangmouseover = false;
        }

    }

    private void OnMouseDrag()
    {
        if (!sudahdatang) //artinya sudahdatang==false
        {
            sedangmouseover = true;
            sudahdatang = true;
        }
    }

    private void OnMouseUp()
    {
        if (sudahdatang)
        {
            sudahdatang = false;
            sedangmouseover = false;
        }
    }

    private void OnMouseDown()
    {
        if (!sudahdatang) //artinya sudahdatang==false
        {
            sedangmouseover = true;
            sudahdatang = true;
        }
    }

}
