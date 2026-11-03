using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KendaliGerak : MonoBehaviour
{
    public int maju;
    public int mundur;
    public int kanan;
    public int kiri;
    public float kecepatan;
    public float kecepatanRotasi = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (maju == 1) 
       { transform.Translate(0, 0 , kecepatan * Time.deltaTime); }
       if (mundur == 1) 
       { transform.Translate(0, 0, -kecepatan * Time.deltaTime); }
       if (kanan == 1) 
       { transform.Rotate(0, kecepatanRotasi * Time.deltaTime, 0); }
       if (kiri == 1) 
       { transform.Rotate(0, -kecepatanRotasi * Time.deltaTime, 0); }
    }

    public void majutekan() 
    { maju = 1; }
    public void majulepas() 
    { maju = 0; }
    public void kanantekan() 
    { kanan = 1; }
    public void kananlepas() 
    { kanan = 0; }
    public void kiritekan() 
    { kiri = 1; }
    public void kirilepas() 
    { kiri = 0; }
    public void mundurtekan() 
    { mundur = 1; }
    public void mundurlepas()
    { mundur = 0; }

}
