using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePuzzle : MonoBehaviour
{

    [SerializeField] GameObject clickableNumberSpacePrefab;

    List<GameObject> objects;


    int[,] puzzle = new [,] {
          { 2, 5, 0, 0, 3, 0, 9, 0, 1 },
          {0, 1, 0, 0, 0, 4, 0, 0, 0},
          {4, 0, 7, 0, 0, 0, 2, 0, 8},
          {0, 0, 5, 2, 0, 0, 0, 0, 0},
          {0, 0, 0, 0, 9, 8, 1, 0, 0},
          {0, 4, 0, 0, 0, 3, 0, 0, 0},
          {0, 0, 0, 3, 6, 0, 0, 7, 2},
          {0, 7, 0, 0, 0, 0, 0, 0, 3},
          {9, 0, 3, 0, 0, 0, 6, 0, 4 } };


    private void Awake()
    {
        for (int r = 0; r < puzzle.Length; r++)
        {
            for (int c = 0; c < puzzle.Length; c++)
            {
                GameObject obj = Instantiate(clickableNumberSpacePrefab, new Vector3(r, c, 0), Quaternion.identity);
                var script = obj.GetComponent<ClickableNumberSpaceController>();
                script.SetID(r * 9 + c);
                script.SetValue(puzzle[r,c]);
                objects.Add(obj);
            }
        }
    }

}
