using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTiles : MonoBehaviour
{
    public GameObject tilePrefab;
    public int sizeOfGrid;
    public GameObject minePrefab;
    public List<GameObject> listOfTiles;
    public List<List<int>> Grid = new List<List<int>>();
    private List<List<int>> newGrid = new List<List<int>>();
    public GameObject prefabMarkTile;

    // Start is called before the first frame update


    void Start()
    {
        GenerateGrid();
        for (int i = 0; i < sizeOfGrid; i++)
        {
            for (int j = 0; j < sizeOfGrid; j++)
            {
                Instantiate(tilePrefab, new Vector3(i * tilePrefab.GetComponent<BoxCollider2D>().size.x, j * tilePrefab.GetComponent<BoxCollider2D>().size.x, -1f), Quaternion.identity);

                if (Grid[i + 1][j + 1] == 1)
                {
                    Instantiate(minePrefab, new Vector2(i* tilePrefab.GetComponent<BoxCollider2D>().size.x, j * tilePrefab.GetComponent<BoxCollider2D>().size.x), Quaternion.identity);
                }
                else
                {
                    Instantiate(listOfTiles[newGrid[i][j]], new Vector2(i * tilePrefab.GetComponent<BoxCollider2D>().size.x, j * tilePrefab.GetComponent<BoxCollider2D>().size.x), Quaternion.identity);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void GenerateGrid()
    {
        //var listOfZeros = new List<int>(new int[sizeOfGrid + 2]);
        var listOfZeros = new List<int>(new int[8 + 2]);
        var listOfZeros1 = new List<int>(){0,0,0,0,0,0,1,0,0,0};
        var listOfZeros2 = new List<int>(){0,0,0,0,0,0,0,1,0,0};
        var listOfZeros3 = new List<int>(){0,0,1,1,0,0,0,0,0,0};
        var listOfZeros4 = new List<int>(){0,0,0,1,0,0,0,0,0,0};
        var listOfZeros5 = new List<int>(){0,0,0,0,0,0,0,0,0,0};
        var listOfZeros6 = new List<int>(){0,0,0,1,0,0,0,0,1,0};
        var listOfZeros7 = new List<int>(){0,0,0,0,0,0,0,0,0,0};
        var listOfZeros8 = new List<int>(){0,1,0,0,0,1,0,0,1,0};
        Grid.Add(listOfZeros);
        Grid.Add(listOfZeros1);
        Grid.Add(listOfZeros2);
        Grid.Add(listOfZeros3);
        Grid.Add(listOfZeros4);
        Grid.Add(listOfZeros5);
        Grid.Add(listOfZeros6);
        Grid.Add(listOfZeros7);
        Grid.Add(listOfZeros8);
        Grid.Add(listOfZeros);
    /*
        var listOfZeros = new List<int>(new int[sizeOfGrid + 2]);
        Grid.Add(listOfZeros);
        for (int i = 0; i < sizeOfGrid; i++)
        {
            List<int> arrayList = new List<int>();
            arrayList.Add(0);
            for (int j = 0; j < sizeOfGrid; j++)
            {
                int randomNumber = Random.Range(0, 2);
                if (randomNumber == 0)
                {
                    arrayList.Add(1);
                }
                if (randomNumber == 1)
                {
                    arrayList.Add(0);
                }
            }
            arrayList.Add(0);
            Grid.Add(arrayList);
        }
        
        
        Grid.Add(listOfZeros);
        */
        for (int i = 1; i < sizeOfGrid + 1; i++)
        {
            List<int> newGridSub = new List<int>();
            for (int j = 1 ; j < sizeOfGrid + 1; j++)
            {
                newGridSub.Add((Grid[i + 1][j] + Grid[i + 1][j + 1] + Grid[i + 1][j - 1] + Grid[i - 1][j] + Grid[i - 1][j + 1] + Grid[i - 1][j - 1] + Grid[i][j + 1] + Grid[i][j - 1]));
            }
            newGrid.Add(newGridSub);
        }

        foreach (List<int> element in Grid)
        {
            foreach (int elementInE in element)
            {
                Debug.Log(elementInE);
            }
        }
    }
}