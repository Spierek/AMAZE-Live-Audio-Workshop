using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using UnityEngine;

[RequireComponent(typeof(GUIText))]

public class MainDebug : MonoBehaviour {
    #region Variables
    public bool                     activate = true;

    private static GUIText          textDisplay;
    private static StringBuilder    text;
    private static List<DebugWord>  textList;
    #endregion

    #region Monobehaviour Methods
    void Awake() {
        textDisplay = GetComponent<GUIText>();
        textDisplay.enabled = activate;
        text = new StringBuilder();
        textList = new List<DebugWord>();
    }

    void LateUpdate() {
        // display debug text
        if (!activate) return;

        AppendList();
        textDisplay.text = text.ToString();
        text.Remove(0, text.Length);
    }
    #endregion

    #region Methods
    public static void Write(string txt) {
        text.Append(txt);
    }

    public static void Write(string name, string value) {
        text.Append(name);
        text.Append(": ");
        text.Append(value);
    }

    public static void WriteLine(string txt) {
        text.AppendLine(txt);
    }

    public static void WriteLine(string name, string value) {
        text.Append(name);
        text.Append(": ");
        text.AppendLine(value);
    }

    public static void WriteLine(string txt, float duration) {
        textList.Add(new DebugWord(txt, Time.realtimeSinceStartup + duration));
    }

    private void AppendList() {
        // CHECKME: is this being displayed correctly?
        for (int i = 0; i < textList.Count; i++) {
            // check if word is still valid
            if (textList[i].time < Time.realtimeSinceStartup) {
                textList.RemoveAt(i);
            }
            if (i < textList.Count)
                text.AppendLine(textList[i].text);
        }
    }
    #endregion
}

public struct DebugWord {
    public string   text;
    public float    time;

    public DebugWord(string text, float time) {
        this.text = text;
        this.time = time;
    }
}