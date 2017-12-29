using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanceView : MonoBehaviour {

    public GameObject menuAR;
    public GameObject menuInfluanceur;
    public GameObject menuChiffre;
    public GameObject menu;
    public GameObject buttonMenu;
    public GameObject buttonBack;
    public GameObject camera;


    private bool isInstanciate;
    private bool isInstanciateChiffre;
    private bool isInstanciateInfluen;
    private bool isMenuDisplay;
    private bool isMenuInfluanceurDisplay;
    private bool isMenuChiffreDisplay;
    // Use this for initialization
    void Start()
    {
        this.isInstanciate = false;
        this.isInstanciateChiffre = false;
        this.isInstanciateInfluen = false;
        this.isMenuDisplay = false;
        this.isMenuChiffreDisplay = false;
        this.isMenuInfluanceurDisplay = false;
        this.menu.SetActive(false);
        this.buttonBack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void onClickedButton()
    {
        if (!this.isInstanciate)
        {
            //this.isInstanciate = GameObjectController.Instance.instanciateNewGameObject(menu.transform, new Vector3(10, 10, 10), new Quaternion(Input.gyro.attitude.x,Input.gyro.attitude.y,-Input.gyro.attitude.z,-Input.gyro.attitude.w));
            //GameObjectController.Instance.findGameObject("Main Camera/Menu").gameObject.SetActive(true);

            Instantiate(menuAR, camera.gameObject.transform.position, Quaternion.identity);
            //menuAR.SetActive(true);
            this.isInstanciate = true;
            menu.GetComponent<UIControllerManager>().Play();
            onClickedButtonMenu();
        }
        else if (this.isInstanciate)
        {
            //this.menuAR.SetActive(false);
            Debug.Log(menuAR.name);
            Destroy(GameObjectController.Instance.findGameObject(menuAR.name+"(Clone)").gameObject);
            this.isInstanciate = false;
        }
    }

    public void onClickedButtonChiffre()
    {
        if (!this.isInstanciateChiffre)
        {
            Instantiate(menuChiffre, camera.gameObject.transform.position, Quaternion.identity);
            //menuAR.SetActive(true);
            this.isInstanciateChiffre = true;
            menu.GetComponent<UIControllerManager>().Play();
            onClickedButtonMenuChiffre();
        }
        else if (this.isInstanciateChiffre)
        {
            //this.menuAR.SetActive(false);
            Destroy(GameObjectController.Instance.findGameObject(menuChiffre.name + "(Clone)").gameObject);
            this.isInstanciateChiffre = false;
        }
    }

    public void onClickedButtonInfluanceur()
    {
        if (!this.isInstanciateInfluen)
        {
            Instantiate(menuInfluanceur, camera.gameObject.transform.position, Quaternion.identity);
            //menuAR.SetActive(true);
            this.isInstanciateInfluen = true;
            menu.GetComponent<UIControllerManager>().Play();
            onClickedButtonMenuInfluanceur();
        }
        else if (this.isInstanciateInfluen)
        {
            //this.menuAR.SetActive(false);
            Destroy(GameObjectController.Instance.findGameObject(menuInfluanceur.name + "(Clone)").gameObject);
            this.isInstanciateInfluen = false;
        }
    }

    public void onClickedButtonMenu()
    {
        if (!this.isMenuDisplay)
        {
            //menu.SetActive(true);
            buttonMenu.SetActive(false);
            buttonBack.SetActive(true);
            this.isMenuDisplay = true;
        }
        else if (this.isMenuDisplay)
        {
            //menu.SetActive(false);
            buttonMenu.SetActive(true);
            buttonBack.SetActive(false);
            this.isMenuDisplay = false;
        }

    }

    public void onClickedButtonMenuInfluanceur()
    {
        if (!this.isMenuDisplay)
        {
            //menu.SetActive(true);
            buttonMenu.SetActive(false);
            buttonBack.SetActive(true);
            this.isMenuInfluanceurDisplay = true;
        }
        else if (this.isMenuDisplay)
        {
            //menu.SetActive(false);
            buttonMenu.SetActive(true);
            buttonBack.SetActive(false);
            this.isMenuInfluanceurDisplay = false;
        }

    }

    public void onClickedButtonMenuChiffre()
    {
        if (!this.isMenuDisplay)
        {
            //menu.SetActive(true);
            buttonMenu.SetActive(false);
            buttonBack.SetActive(true);
            this.isMenuChiffreDisplay = true;
        }
        else if (this.isMenuDisplay)
        {
            //menu.SetActive(false);
            buttonMenu.SetActive(true);
            buttonBack.SetActive(false);
            this.isMenuChiffreDisplay = false;
        }

    }

    //__________________________________________________PRIVATE____________________________________________________________________
    private bool setBoolWhenMenuDisplay(bool isToSet)
    {
        if (!isToSet)
            isToSet = true;
        else if (isToSet)
            isToSet = false;
        return isToSet;
    }
}
