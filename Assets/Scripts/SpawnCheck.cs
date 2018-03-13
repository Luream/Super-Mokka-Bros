using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCheck : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject[] Objects = GameObject.FindGameObjectsWithTag("InstableBlock");
            foreach (GameObject block in Objects)
            {
                block.SendMessage("restoreIB");
            }
        }
    }
}
