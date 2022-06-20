using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    // A single script containing all asset references.

    public static GameAssets instance;

    private void Awake()
    {
        instance = this;
    }

    public Sprite snakeHeadSprite;
    public Sprite snakeBodySprite;
    public Sprite foodSprite;
}
