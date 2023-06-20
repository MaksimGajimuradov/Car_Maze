using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ����� ����� ������������� ����� ��������

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {          // ���� ������ � ����� Player ���������� ������ � ����� Finish, �� � SceneManager ��������� �������� ����� +1
        if (this.CompareTag("Player") && other.CompareTag("Finish"))   
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
