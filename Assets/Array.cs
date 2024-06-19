using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] array;
    public int currentIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (currentIndex < array.Length)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex++;
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (currentIndex >= 0)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex--;
            }
            else
            {
                currentIndex = array.Length - 1;
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex--;
            }
        }
    }
    void DeactivateAll()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i].SetActive(false);
            // desactiva en este caso cada cubes.Set active (true) = activa 
        }

    }
    void ActivateAll()
    {

        for (int i = 0; i < array.Length; i++)
        {
            array[i].SetActive(true);
            // desactiva en este caso cada cubes.Set active (true) = activa 
        }

    }
    void ActivateByIndex(int index)
    {
        array[index].SetActive(true);
    }
}
