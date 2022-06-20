using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject snake;

    void Start()
    {
        GameObject snakeHeadGameObject = new GameObject();
        SpriteRenderer snakeSpriteRenderer = snakeHeadGameObject.AddComponent<SpriteRenderer>();
        snakeHeadGameObject.name = "Snake";
        snakeHeadGameObject.AddComponent(typeof(Snake));
        snakeSpriteRenderer.sprite = GameAssets.instance.snakeHeadSprite;

    }
}
