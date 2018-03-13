using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathDefinition : MonoBehaviour
{
    public Transform[] Points;

    public IEnumerator<Transform> GetPathEnumerator()
    {
        if (Points == null || Points.Length < 1)
            yield break;

        var direction = 1;
        var index = 0;
        while (true)
        {
            yield return Points[index];

            if (Points.Length == 1)
                continue;
            if (index <= 0)
                direction = 1;
            else if (index >= Points.Length - 1)
                direction = -1;

            index = index + direction;
        }
    }

    public void OnDrawGizmos()
    {
        if (Points == null || Points.Length < 2)
            return;

        for (var i = 1; i < Points.Length; i++)
        {
            Gizmos.DrawLine(Points[i - 1].position, Points[i].position);
        }
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}

// Für Erklärung https://www.3dbuzz.com/training/view/creating-2d-games-in-unity-45/placing-our-tiles/moving-platforms besuchen