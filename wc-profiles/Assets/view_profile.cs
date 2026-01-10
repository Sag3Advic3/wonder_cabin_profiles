using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class view_profile : MonoBehaviour
{
    private GameObject[] errorImages;
    void Start(){
        errorImages = GameObject.FindGameObjectsWithTag("error");
        foreach(GameObject errorImage in errorImages){
            errorImage.SetActive(false);
        }
    }

    public void ViewProfile(){
        string buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        PlayerPrefs.SetString("view_profile_username", buttonName);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Profile");
    }

    public void NoAccess(){
        foreach(GameObject errorImage in errorImages){
            errorImage.SetActive(true);
        }
    }

    public void CloseError(){
        foreach(GameObject errorImage in errorImages){
            errorImage.SetActive(false);
        }
    }
}
