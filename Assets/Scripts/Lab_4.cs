using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab_4 : MonoBehaviour
{
    [SerializeField] private GameObject NpcText;
    [SerializeField] private GameObject Hint;
    void Start()
    {
        NpcText.SetActive(false); //����� "������� E"
        Hint.SetActive(false); //���� ���������
    }

   //�����, ������� ����������� ��� ����������� ������� � �������� 
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
    //�����, ������� ����������� ��� ��������� ������� �� ��������
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NpcText.SetActive(false);
            Hint.SetActive(false);
        }
    }
}
