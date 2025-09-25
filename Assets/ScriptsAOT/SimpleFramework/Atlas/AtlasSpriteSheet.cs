using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class AtlasSpriteSheet : MonoBehaviour
{
    public SpriteAtlas mSpriteAtlas;
    public Sprite GetSprite(string name)
    {
        return mSpriteAtlas.GetSprite(name);
    }

    public Sprite[] GetSprites()
    {
        Sprite[] mSprites = null;
        mSpriteAtlas.GetSprites(mSprites);
        return mSprites;
    }
}
