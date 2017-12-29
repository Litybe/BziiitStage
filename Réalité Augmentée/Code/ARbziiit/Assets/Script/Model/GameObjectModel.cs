using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectModel : MonoBehaviour
{

    private static GameObjectModel instance;

    private GameObjectModel()
    {

    }

    public static GameObjectModel Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObjectModel();
            }
            return instance;
        }
    }

    public bool instanciateNewGameObject(Transform prefab,Vector3 pos,Quaternion rot)
    {
        Instantiate(prefab, pos, rot);
        return true;
    }

    public bool destroyGameObject(Transform prefab)
    {
        Destroy(prefab);
        return false;
    }

    public Transform findGameObject(string name)
    {
        return GameObject.Find(name).transform;
    }
}
