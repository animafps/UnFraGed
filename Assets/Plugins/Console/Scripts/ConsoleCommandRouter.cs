using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class ConsoleCommandRouter : MonoBehaviour {
    void Start () {
        var repo = ConsoleCommandsRepository.Instance;
        repo.RegisterCommand("load", Load);
        repo.RegisterCommand("sensitivity", Sensitivity);
        repo.RegisterCommand("sens", Sensitivity);
        repo.RegisterCommand("fpsmax", FPSMax);
        repo.RegisterCommand("vsync", VSync);
        repo.RegisterCommand("framebuffer", Buffer);
        repo.RegisterCommand("shadows", Shadows);
        repo.RegisterCommand("preset", QualityPreset);
        repo.RegisterCommand("presets", GetPresets);
        repo.RegisterCommand("fullscree", FullscreenMode);
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

    public string FPSMax(params string[] args)
    {
        var max = args[0];
        Application.targetFrameRate = System.Convert.ToInt16(max);
        return "Changed Max FPS to: " + max;
    }

    public string VSync(params string[] args)
    {
        var v_sync = args[0];
        QualitySettings.vSyncCount = System.Convert.ToInt16(v_sync);
        return "Changed VSync: " + v_sync;
    }

    public string Buffer(params string[] args)
    {
        var buffercount = args[0];
        QualitySettings.maxQueuedFrames = System.Convert.ToInt16(buffercount);
        return "Changed Frame Buffer Size to: " + buffercount;
    }

    public string Shadows(params string[] args) // Disable, HardOnly, All
    {
        var shadow = args[0];
        if(shadow == "on")
        {
            QualitySettings.shadows = ShadowQuality.All;
        }
        if(shadow == "hardonly")
        {
            QualitySettings.shadows = ShadowQuality.HardOnly;
        }
        if(shadow == "off")
        {
            QualitySettings.shadows = ShadowQuality.Disable;
        }
        return "Changed Shadow type to: " + shadow;
    }

    public string QualityPreset(params string[] args) //
    {
        var preset = args[0];
        QualitySettings.SetQualityLevel(System.Convert.ToInt16(preset));
        return "Changed Video Quality Preset to: " + preset;
    }

    public string GetPresets(params string[] args)
    {
        return "Current Quality Presets avaliable: " + QualitySettings.names;
    }

    public string FullscreenMode(params string[] args)
    {
        var fullscreenmode = args[0];
        if(fullscreenmode == "fullscreen")
        {
            FullScreenMode.ExclusiveFullScreen;
        }
        if(fullscreenmode == "windowed")
        {
            FullScreenMode.FullScreenWindow;
        }
        return "Changed Fullscreen Mode to: " + fullscreenmode;
    }
}