using UnityEngine;
using System.Collections;

public class MoverConstanteCasa : MonoBehaviour
{
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        
        transform.Translate(0, 0.6f, 0);

  
    }
}