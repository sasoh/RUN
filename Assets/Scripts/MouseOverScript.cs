using UnityEngine;
using System.Collections;

public class MouseOverScript : MonoBehaviour
{
    public float TimeLookedAt = 0.0f;

    private bool shouldIncrease = false;

    // Update is called once per frame
    void Update()
    {
        if (shouldIncrease == true)
        {
            TimeLookedAt += Time.deltaTime;
        }
    }

    void OnMouseEnter()
    {
        shouldIncrease = true;
        TimeLookedAt = 0.0f;

        MeshRenderer mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.red;
    }

    void OnMouseExit()
    {
        shouldIncrease = false;
        TimeLookedAt = 0.0f;

        MeshRenderer mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.white;
    }
}
