using System;
using UnityEditor;
using UnityEngine;

class MultiBuild {

  static string[] getScenes(){
    EditorBuildSettingsScene[] buildScenes = EditorBuildSettings.scenes;
    string[] scenes = new string[buildScenes.Length];
    for (int i = 0; i < buildScenes.Length; i++){
      scenes[i] = buildScenes[i].path;
    }
    return scenes;
  }

  static void All() {
    Android();
    iOS();
    Linux();
    Mac();
    WebGL();
    Win();
  }

  static void Android() {
    string filename = Environment.GetCommandLineArgs()[1];
    BuildPipeline.BuildPlayer(getScenes(), "Builds/Android/" + filename + ".apk", BuildTarget.Android, BuildOptions.None);
  }

  static void iOS() {
    string filename = Environment.GetCommandLineArgs()[1];
    BuildPipeline.BuildPlayer(getScenes(), "Builds/iOS/" + filename, BuildTarget.iOS, BuildOptions.None);
  }

  static void Linux() {
    string filename = Environment.GetCommandLineArgs()[1];
    BuildPipeline.BuildPlayer(getScenes(), "Builds/Linux/" + filename + "/" + filename, BuildTarget.StandaloneLinux64, BuildOptions.None);
  }

  static void Mac() {
    string filename = Environment.GetCommandLineArgs()[1];
    BuildPipeline.BuildPlayer(getScenes(), "Builds/Mac/" + filename + ".app", BuildTarget.StandaloneOSX, BuildOptions.None);
  }

  static void WebGL() {
    string filename = Environment.GetCommandLineArgs()[1];
  	BuildPipeline.BuildPlayer(getScenes(), "Builds/WebGL/" + filename, BuildTarget.WebGL, BuildOptions.None);
  }

  static void Win() {
    string filename = Environment.GetCommandLineArgs()[1];
    BuildPipeline.BuildPlayer(getScenes(), "Builds/Win/" + filename + "/" + filename, BuildTarget.StandaloneWindows64, BuildOptions.None);
  }

}
