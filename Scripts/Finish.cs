using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Нужно чтобы переключаться между уровнями

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {          // Если объект с тегом Player пересекает объект с тегом Finish, то в SceneManager загружаем активную сцену +1
        if (this.CompareTag("Player") && other.CompareTag("Finish"))   
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
