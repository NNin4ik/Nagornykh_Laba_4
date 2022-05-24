using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab_4 : MonoBehaviour
{
    [SerializeField] private GameObject NpcText;
    [SerializeField] private GameObject Hint;
    void Start()
    {
        NpcText.SetActive(false); //Текст "Нажмите E"
        Hint.SetActive(false); //Текс подсказки
    }

   //Метод, который срабатывает при приближении объекта к триггеру 
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NpcText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                NpcText.SetActive(false);
                Hint.SetActive(true);
            }
        }
    }
    //Метод, который срабатывает при отдалении объекта от триггера
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NpcText.SetActive(false);
            Hint.SetActive(false);
        }
    }
}
