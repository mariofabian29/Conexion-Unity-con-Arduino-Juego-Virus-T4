using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;



public class MoverConArduino : MonoBehaviour
{

    private int dir1;
    private int dir2;
    private int dir3;
    private int btn1;

    public GameObject objeto; 

    public float distanciaMov = 50;


    SerialPort PuertoSerial = new SerialPort("COM5", 9600);

    void Start()
    {
        PuertoSerial.Open();
        PuertoSerial.ReadTimeout = 1;

        objeto = GameObject.Find("Escudo");
    }
     
    void Update()
    {
        if (PuertoSerial.IsOpen)
        {
            try
            {
                mover(PuertoSerial.ReadLine());

            }
            catch (System.Exception)
            {

            }

        }

    }

    void mover(string datoArduino)
    {
        string[] datosArray = datoArduino.Split(char.Parse(","));

        if (datosArray.Length == 4)
        {
            dir1 = int.Parse(datosArray[0]);
            dir2 = int.Parse(datosArray[1]);
            dir3 = int.Parse(datosArray[2]);
            btn1 = int.Parse(datosArray[3]);

            print(dir1 + " " + dir2 + " " + dir3 + " " +  btn1);
        }
        
        if (btn1 == 1)
        {
            Debug.Log("Presionado - 1");

            objeto.SetActive(true);
            /*
               GameObject.FindWithTag("Finish").SetActive(false);
               gameObject.SetActive(false);
               */
        }

        if (btn1 == 0) 
        {
            Debug.Log("Suelto - 0");

            objeto.SetActive(false);

            /*GameObject.FindWithTag("Finish").SetActive(true);
            gameObject.SetActive(true);*/
        }

        if (PuertoSerial.IsOpen)
        {
            transform.localPosition = new Vector3(dir3, dir1, dir2);
        }


    } 
}









