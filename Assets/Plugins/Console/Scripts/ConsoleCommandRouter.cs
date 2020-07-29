using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ConsoleCommandRouter : MonoBehaviour {
    void Start () {
        var repo = ConsoleCommandsRepository.Instance;
        repo.RegisterCommand("load", Load);
        repo.RegisterCommand("sensitivity", Sensitivity);
    }

    public string Load(params string[] args) {
        var filename = args[0];
        SceneManager.LoadScene(filename);
        return "Loaded " + filename;
    }

    public string Sensitivity(params string[] args)
    {
        var sens = args[0];
        PlayerPrefs.SetFloat("Sensitivity", float.Parse(sens));
        return "Changed sensitivity to: " + sens;
    }
}