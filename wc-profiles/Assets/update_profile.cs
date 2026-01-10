using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class update_profile : MonoBehaviour
{
    public TextMeshProUGUI usernameText;
    public TextMeshProUGUI abilityText;
    public TextMeshProUGUI creationDateText;
    public TextMeshProUGUI statusText;
    public Image profilePicture;
    public Image statsPicture;

    public Sprite babyg1rlProfilePic;
    public Sprite babyg1rlStatsPic;
    public Sprite chengProfilePic;
    public Sprite chengStatsPic;
    public Sprite doppoProfilePic;
    public Sprite doppoStatsPic;
    public Sprite gigoloProfilePic;
    public Sprite gigoloStatsPic;
    public Sprite jammyProfilePic;
    public Sprite jammyStatsPic;
    public Sprite nifftyProfilePic;
    public Sprite nifftyStatsPic;
    public Sprite phant0mProfilePic;
    public Sprite phant0mStatsPic;
    public Sprite princ3ssProfilePic;
    public Sprite princ3ssStatsPic;
    public Sprite viviProfilePic;
    public Sprite viviStatsPic;

    void Start()
    {
        switch(PlayerPrefs.GetString("view_profile_username")){
            case "babyg1rl_btn":
                usernameText.text = "BABYG1RL_";
                abilityText.text = "ABILITY: TBD";
                creationDateText.text = "USER JOINED: FEB 2014";
                statusText.text = "STATUS: ALIVE";
                profilePicture.sprite = babyg1rlProfilePic;
                statsPicture.sprite = babyg1rlStatsPic;
                break;
            case "chengxioashi_btn":
                usernameText.text = "CHENGXIOASHI";
                abilityText.text = "ABILITY: TBD";
                creationDateText.text = "USER JOINED: FEB 2014";
                statusText.text = "STATUS: ALIVE";
                profilePicture.sprite = chengProfilePic;
                statsPicture.sprite = chengStatsPic;
                break;
            case "doppo_btn":
                usernameText.text = "DOPPO";
                abilityText.text = "ABILITY: TBD";
                creationDateText.text = "USER JOINED: FEB 2014";
                statusText.text = "STATUS: ALIVE";
                profilePicture.sprite = doppoProfilePic;
                statsPicture.sprite = doppoStatsPic;
                break;
            case "gigolo123_btn":
                usernameText.text = "GIGOLO";
                abilityText.text = "ABILITY: TBD";
                creationDateText.text = "USER JOINED: FEB 2014";
                statusText.text = "STATUS: ALIVE";
                profilePicture.sprite = gigoloProfilePic;
                statsPicture.sprite = gigoloStatsPic;
                break;
            case "jammy_boi_11_btn":
                usernameText.text = "JAMMY_BOI_11";
                abilityText.text = "ABILITY: LUCKY";
                creationDateText.text = "USER JOINED: MAR 2013";
                statusText.text = "STATUS: ALIVE";
                profilePicture.sprite = jammyProfilePic;
                statsPicture.sprite = jammyStatsPic;
                break;
            case "niffty_btn":
                usernameText.text = "NIFFTY"; 
                abilityText.text = "ABILITY: TBD"; 
                creationDateText.text = "USER JOINED: FEB 2014"; 
                statusText.text = "STATUS: ALIVE"; 
                profilePicture.sprite = nifftyProfilePic;
                statsPicture.sprite = nifftyStatsPic;
                break;
            case "ph4nt0m_btn":
                usernameText.text = "PH4NT0M"; 
                abilityText.text = "ABILITY: TBD";
                creationDateText.text = "USER JOINED: FEB 2014"; 
                statusText.text = "STATUS: ALIVE"; 
                profilePicture.sprite = phant0mProfilePic;
                statsPicture.sprite = phant0mStatsPic;
                break;
            case "princ3ssgh0st_btn":
                usernameText.text = "PRINC3SSGH0ST";
                abilityText.text = "ABILITY: TBD";
                creationDateText.text = "USER JOINED: FEB 2014";
                statusText.text = "STATUS: ALIVE";
                profilePicture.sprite = princ3ssProfilePic;
                statsPicture.sprite = princ3ssStatsPic;
                break;
            case "vivi_btn":
                usernameText.text = "VIVI";
                abilityText.text = "ABILITY: TBD";
                creationDateText.text = "USER JOINED: FEB 2014";
                statusText.text = "STATUS: ALIVE";
                profilePicture.sprite = viviProfilePic;
                statsPicture.sprite = viviStatsPic;
                break;
            default:
                // Handle unknown case
                break;
        }
        
    }

    public void BackToMenu(){
        SceneManager.LoadScene("HomePage");
    }
}
