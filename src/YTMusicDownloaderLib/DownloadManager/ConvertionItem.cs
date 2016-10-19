﻿/*
    Copyright 2016 Christian Klemm

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/

using System;
using System.IO;
using System.Threading.Tasks;
using NAudio.Wave;
using YTMusicDownloaderLib.RetrieverEngine;

namespace YTMusicDownloaderLib.DownloadManager
{
    public class ConvertionItem : DownloadManagerItem
    {
        public ConvertionItem(PlaylistItem item, string currentPath, string newPath) : base(item)
        {
            CurrentPath = currentPath;
            NewPath = newPath;
        }

        public string CurrentPath { get; }
        public string NewPath { get; }

        public override async void StartDownload()
        {
            await Task.Run(() =>
            {
                var oldExtension = Path.GetExtension(CurrentPath)?.ToLower();
                var newExtension = Path.GetExtension(NewPath)?.ToLower();

                if ((oldExtension == ".m4a") && (newExtension == ".mp3"))
                    try
                    {
                        using (var reader = new MediaFoundationReader(CurrentPath))
                        {
                            MediaFoundationEncoder.EncodeToMp3(reader, NewPath);
                        }

                        File.Delete(CurrentPath);

                        OnDownloadItemDownloadCompleted(new DownloadCompletedEventArgs(false));
                    }
                    catch (Exception ex)
                    {
                        OnDownloadItemDownloadCompleted(new DownloadCompletedEventArgs(true, ex));
                    }
                else if ((oldExtension == ".mp3") && (newExtension == ".m4a"))
                    try
                    {
                        using (var reader = new MediaFoundationReader(CurrentPath))
                        {
                            MediaFoundationEncoder.EncodeToAac(reader, NewPath);
                        }

                        File.Delete(CurrentPath);

                        OnDownloadItemDownloadCompleted(new DownloadCompletedEventArgs(false));
                    }
                    catch (Exception ex)
                    {
                        OnDownloadItemDownloadCompleted(new DownloadCompletedEventArgs(true, ex));
                    }
                else
                    OnDownloadItemDownloadCompleted(new DownloadCompletedEventArgs(true,
                        new InvalidOperationException("No supported extension")));
            });
        }
    }
}