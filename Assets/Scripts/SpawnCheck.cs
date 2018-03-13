<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCheck : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Treffer1");
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject[] Objects = GameObject.FindGameObjectsWithTag("InstableBlock");
            foreach (GameObject block in Objects)
            {
                block.SendMessage("restoreIB");
                Debug.Log("Treffer");
            }
        }
    }
}
>>>>>>> a640cac8fb4e6612d0fb3d48d83b4d06688507d2
