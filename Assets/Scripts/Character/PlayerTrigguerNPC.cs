using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigguerNPC : MonoBehaviour
{
    //Accede al script levelChager para validar el cambio de escena
    [SerializeField]
    private LevelChanger levelChanger;

    private void Start()
    {
        levelChanger = FindObjectOfType<LevelChanger>().GetComponent<LevelChanger>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "door1")
        {
            levelChanger.FadeToNextLevel_1();
            Debug.Log("TRIGUER OK!");
        }
        else if (other.gameObject.tag == "door2")
        {
            levelChanger.FadeToNextLevel_2();
            Debug.Log("TRIGUER OK!");
        }
        else if (other.gameObject.tag == "door3")
        {
            levelChanger.FadeToNextLevel_3();
            Debug.Log("TRIGUER OK!");
        }
        else if (other.gameObject.tag == "door4")
        {
            levelChanger.FadeToNextLevel_0();
            Debug.Log("TRIGUER OK!");
        }
        else
        {
            return;
        }
    }

   
}
