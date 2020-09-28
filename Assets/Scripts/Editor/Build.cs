using System;
using System.Collections.Generic;
using UnityEditor;

namespace Tooling
{
    public class Build
    {
        static string[] SCENES = FindEnabledEditorScenes();

        private static string RootBuildFolder = "Builds/";
        static string OutputFolder = "iOS";

        private static void BuildIOSDebug()
        {
            GenericBuild(SCENES,
                RootBuildFolder + OutputFolder + "_Debug", 
                BuildTargetGroup.iOS,
                BuildTarget.iOS,
                BuildOptions.Development);
        }

        private static void BuildIOSRelease()
        {
            GenericBuild(SCENES,
                RootBuildFolder + OutputFolder + "_Release",
                BuildTargetGroup.iOS,
                BuildTarget.iOS);
        }

        private static string[] FindEnabledEditorScenes() 
        {
            var editorScenes = new List<string>();
            foreach(var scene in EditorBuildSettings.scenes) 
            {
                if (!scene.enabled) continue;
                editorScenes.Add(scene.path);
            }
            return editorScenes.ToArray();
        }

        static void GenericBuild(string[] scenes, string targetDir, BuildTargetGroup buildTargetGroup, 
            BuildTarget buildTarget, BuildOptions buildOptions = BuildOptions.None)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(buildTargetGroup, buildTarget);
            var res = BuildPipeline.BuildPlayer(scenes, targetDir, buildTarget, buildOptions);
            if (!res)
            {
                throw new Exception("BuildPlayer failure: " + res);
            }
        }
    }
}

