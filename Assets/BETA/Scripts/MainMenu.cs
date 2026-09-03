using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using XDiffGui.Options;

namespace BETA7
{
    public class MainMenu : MonoBehaviour
    {
        public static GameDataManager instance;
        public GameObject MenuBack;
        public GameObject Setting;


        public void BtnStart()
        {
            SceneManager.LoadScene("SampleScene");
        }
        public void BtnSetting()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenSetting", 1.5f);
        }
        public void BtnExit()
        {
            Application.Quit();
        }
        public void BtnReturn()
        {

        }
        public void SetID()
        {
            GameDataManager.instance.SetID(textID.text);
        }
        public void BtnBGSound()
        {
            if(BackMusic.GetCompponent<Text>().text == "¹è°æÀ½¾Ç")
            {
                GameDataManager.instance.isMusic = 0;
            }
            else
            {
                GameDataManager.instance.isMusic = 1;
            }
            GameDataManager.instance.SaveData();
        }
        public void SetData()
        {
            if (GameDataManager.instance.isMusic == 0)
            {
                BackMusic.GetComponent<Text>().text = "¹è°æÀ½¾Ç";
            }
            else if (GameDataManager.instance.isMusic == 0)
            {
                BackMusic.GetComponent<Text>().text = "¹è°æÀ½¾Ç ²û";
            }
            if(GameDataManager.instance.isSound == 1)
            {
                BackSound.GetComponent<Text>().text = "È¿°úÀ½";
            }
            else if (GameDataManager.instance.isSound == 0)
            {
                BackSound.GetComponent<Text>().text = "È¿°úÀ½ ²û";
            }
            GameDataManager.instance.SaveData();
        }
        void OpenSetting()
        {
            Setting.SetActive(true);
            Setting.GetComponent<Animator>().SetTrigger("Open");
        }
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
