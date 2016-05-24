using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ResetLevel();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            ResetLevel();
        }
    }

    void ResetLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
