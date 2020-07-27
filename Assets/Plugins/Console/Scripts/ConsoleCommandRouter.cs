using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ConsoleCommandRouter : MonoBehaviour {
    void Start () {
        var repo = ConsoleCommandsRepository.Instance;
        repo.RegisterCommand("load", Load);
    }

    public string Load(params string[] args) {
        var filename = args[0];
        SceneManager.LoadScene(filename);
        return "Loaded " + filename;
    }
}