using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject right;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        right.SetActive(false);
        if (other.gameObject.CompareTag("ball"))
        {
            right.SetActive(true);

        }
    }
}
