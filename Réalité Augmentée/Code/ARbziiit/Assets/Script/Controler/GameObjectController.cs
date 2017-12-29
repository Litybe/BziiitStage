using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectController {

    private static GameObjectController instance;

    private GameObjectController()
    {

    }

    public static GameObjectController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObjectController();
            }
            return instance;
        }
    }

    public bool instanciateNewGameObject(Transform prefab, Vector3 pos, Quaternion rot)
    {
        return GameObjectModel.Instance.instanciateNewGameObject(prefab, pos, rot);
    }

    public bool destroyGameObject(Transform prefab)
    {
        return GameObjectModel.Instance.destroyGameObject(prefab);
    }

    public Transform findGameObject(string name)
    {
        return GameObjectModel.Instance.findGameObject(name);
    }
}
