using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kendali : MonoBehaviour
{
    public Transform posisi;
    public GameObject obyekkopian;
    Color warnaacak;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        posisi = gameObject.transform;
    }

    // untuk mendeteksi klik pada objek
    private void OnMouseDown()
    {
        acakwarna();
        Destroy(gameObject, 2.0f);
        tigabenda();
    }

    private void OnMouseUp()
    {

    }

    private void OnDestroy()
    {
        //Vector3 posisi;
        //posisi= transform.position;
        //Instantiate(obyekkopian);
        //Instantiate(obyekkopian, posisi);
    }

    // untuk membuat atau duplikasi 3 cube baru
    void tigabenda()
    {
        GameObject obyekbaru = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obyekbaru.transform.position =
            new Vector3(
                this.transform.position.x,
                this.transform.position.y,
                this.transform.position.z
            );
        Rigidbody rb = obyekbaru.AddComponent<Rigidbody>();
        var skripbaru = obyekbaru.AddComponent<Kendali>();
        Color warna1 = warnaacak;
        obyekbaru.GetComponent<Renderer>().material.color = warna1;

        GameObject obyekbaru1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obyekbaru1.transform.position =
            new Vector3(
                this.transform.position.x,
                this.transform.position.y,
                this.transform.position.z
            );
        Rigidbody rb2 = obyekbaru1.AddComponent<Rigidbody>();
        var skripbaru2 = obyekbaru1.AddComponent<Kendali>();
        Color warna2 = warnaacak;
        obyekbaru1.GetComponent<Renderer>().material.color = warna2;

        GameObject obyekbaru2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obyekbaru2.transform.position =
            new Vector3(
                this.transform.position.x,
                this.transform.position.y,
                this.transform.position.z
            );
        Rigidbody rb3 = obyekbaru2.AddComponent<Rigidbody>();
        var skripbaru3 = obyekbaru2.AddComponent<Kendali>();
        Color warna3 = warnaacak;
        obyekbaru2.GetComponent<Renderer>().material.color = warna3;
    }

    // untuk mengacak warna
    void acakwarna()
    {
        warnaacak = new Color
        (Random.Range(0.2f, 0.8f),
        Random.Range(0.2f, 0.8f),
        Random.Range(0.2f, 0.8f),
        1
  );
    }
}