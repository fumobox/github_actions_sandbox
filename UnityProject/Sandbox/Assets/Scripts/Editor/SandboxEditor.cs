using System;
using UnityEditor;
using UnityEngine;

namespace Sandbox
{
    public static class SandboxEditor
    {
        public static void BuildAndroid()
        {
            Debug.Log($"Build Start: {DateTime.Now}");

            EditorUserBuildSettings.allowDebugging = true;
            EditorUserBuildSettings.development = true;
            EditorUserBuildSettings.connectProfiler = true;

            var sceneList =
            new[] {
                "Assets/Scenes/Sandbox.unity",
            };

            var buildDir = "./Build/android/";

            var report = BuildPipeline.BuildPlayer(
                sceneList,
                $"{buildDir}{PlayerSettings.productName}.apk",
                BuildTarget.Android,
                BuildOptions.AllowDebugging | BuildOptions.Development
            );

            Debug.Log($"Build Result: {report.summary.result}");
        }

        public static void Test()
        {
        }

    }
}
