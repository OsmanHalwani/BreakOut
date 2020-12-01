using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{

    public int rows=10;
    public int cols=10;
    public float spacing=0.1f;
    public GameObject brickPreFab;

    private List<GameObject> bricks = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetLevel()
    {
        foreach(GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for(int x=0;x<cols;x++)
        {
            for(int y=0;y<rows;y++)
            {
                Vector2 spawnPos =(Vector2)transform.position + new Vector2(
                                    x * (brickPreFab.transform.localScale.x + spacing),
                                    -y * (brickPreFab.transform.localScale.y + spacing)
                                    );
                GameObject brick = Instantiate(brickPreFab, spawnPos, Quaternion.identity);
                float i = Random.Range(0, 255);
                float j = Random.Range(0, 255);
                float k = Random.Range(0, 255);

                Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
                brick.GetComponent<SpriteRenderer>().color = newColor;
            bricks.Add(brick);
            }
        }

    }
    public void RemoveBrick(Brick brick)
    {
        bricks.Remove(brick.gameObject);
        if(bricks.Count==0)
        {
            ResetLevel();
        }
    }
}
