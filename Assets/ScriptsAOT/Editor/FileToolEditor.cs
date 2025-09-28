
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class FileToolEditor
{
    public static void OpenFolder(string path)
    {
        if (Directory.Exists(path))
        {
            System.Diagnostics.Process.Start(path);
        }
    }

    public static void CopyFolder(string fromPath, string toPath)
    {
        CopyDir(fromPath, toPath);
        Debug.Log("Copy Success : From: " + fromPath + " To: " + toPath);
    }

    public static void CreateFolder(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    public static void DeleteFolder(string path)
    {
        if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
            if (File.Exists(path))
            {
                File.Delete(path + ".meta");
            }
        }
    }

    public static string GetDirName(string path)
    {
        if (Directory.Exists(path))
        {
            if (path.EndsWith("/"))
            {
                path = path.Substring(0, path.Length - 1);
            }

            int nIndex = path.LastIndexOf("/");
            return path.Substring(nIndex + 1);
        }

        return null;
    }

    public static string GetDirParentDir(string path)
    {
        if (Directory.Exists(path))
        {
            if (path.EndsWith("/"))
            {
                path = path.Substring(0, path.Length - 1);
            }

            int nIndex = path.LastIndexOf("/");
            return path.Substring(0, nIndex);
        }

        return null;
    }

    private static string GetSubDirPath(string rootDir, string path)
    {
        if (Directory.Exists(rootDir))
        {
            return path.Substring(rootDir.Length + 1);
        }
        return path;
    }

    private static void CopyDir(string origin, string target)
    {
        if (!Directory.Exists(target))
        {
            Directory.CreateDirectory(target);
        }

        foreach (string fi in Directory.GetDirectories(origin, "*", SearchOption.AllDirectories))
        {
            if (Path.GetExtension(fi) == ".meta")
            {
                continue;
            }

            string dirPath = Path.Combine(target, GetSubDirPath(origin, fi));
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }

        foreach (string fi in Directory.GetFiles(origin, "*", SearchOption.AllDirectories))
        {
            if (Path.GetExtension(fi) == ".meta")
            {
                continue;
            }

            File.Copy(fi, Path.Combine(target, GetSubDirPath(origin, fi)), true);
        }
    }

    public static void ClearEmptyFolder(string Dir)
    {
        foreach (var v in Directory.GetDirectories(Dir, "*", SearchOption.TopDirectoryOnly))
        {
            bool isEmptyFolder = true;
            foreach (string v1 in Directory.GetFiles(v, "*", SearchOption.TopDirectoryOnly))
            {
                if (Path.GetExtension(v1) != ".meta")
                {
                    isEmptyFolder = false;
                }
            }

            if(isEmptyFolder)
            {
                isEmptyFolder = Directory.GetDirectories(v, "*", SearchOption.TopDirectoryOnly).Length == 0;
            }
            
            if (isEmptyFolder)
            {
                DeleteFolder(v);
                Debug.Log("Empty Folder: " + v);
            }
            else
            {
                ClearEmptyFolder(v);
            }
        }
    }



}