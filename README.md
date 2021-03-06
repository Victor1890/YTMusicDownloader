<img src="https://github.com/chris579/YTMusicDownloader/blob/master/src/YTMusicDownloader/Resources/logo_black.png?raw=true" width="100" height="100" />

# YouTube Music Downloader
A powerful tool to sync your favourite YouTube music with your computer.

*This project is more or less abandoned but should still work.*

[![Github All Releases](https://img.shields.io/github/downloads/chris579/YTMusicDownloader/total.svg)](https://github.com/chris579/YTMusicDownloader/releases)
[![Gitter](https://badges.gitter.im/gitterHQ/gitter.svg)](https://gitter.im/YTMusicDownloader/Main)

This tool offers you the possibility to download YouTube videos as a sound file and keep them in sync with your local library.
Unlike other YouTube converters you can even download complete playlists and sync them without the need to download all songs again when you added new tracks to your playlist.

**Latest release**  
[![GitHub release](https://img.shields.io/github/release/chris579/YTMusicDownloader.svg)](https://github.com/chris579/YTMusicDownloader/releases)  

**Features in progress**  
[![Stories in Progress](https://badge.waffle.io/chris579/YTMusicDownloader.svg?label=in%20progress&title=In%20Progress)](http://waffle.io/chris579/YTMusicDownloader)

| Branch | Status |
| --- | --- |
| Stable branch | [![Build status master](https://ci.appveyor.com/api/projects/status/ppfs8sdxn16l62af/branch/master?svg=true)](https://ci.appveyor.com/project/chris579/ytmusicdownloader) |
| Development branch | [![Build status](https://ci.appveyor.com/api/projects/status/ppfs8sdxn16l62af/branch/development?svg=true)](https://ci.appveyor.com/project/chris579/ytmusicdownloader) |

### Features
- Download complete playlists directly from YouTube
- Create different workspaces for different kinds of music
- No 3rd party web dependencies - use this tool from everywhere around the world
- Simple and easy to use
- Fast direct downloads from YouTube (~ 5 seconds for a song with standard length)
- Different download formats: M4A and MP3
- Keep your local music library in sync with your YouTube playlists
- Handle even playlists with 1000+ items


### Planned features
- Full iTunes support: Sync your local workspace with a iTunes library to have your music directly available in your favourite music player
- Add single videos to your workspace: A playlist out there is missing your favourite song? Directly add it to your workspace
- Sync multiple playlists with your workspace: Combine several playlists out there in one workspace
- And even much more to come...


### Requirements
- Windows 7 or later (other versions are not directly supported)
- .NET Framework 4.5 or later
- **NOTE: This is an early version (even pre-alpha) so bugs and errors can occur and included features are not final!**

### Screenshots
<details>
  <summary>Toggle</summary>
  
  ![Main page](https://cloud.githubusercontent.com/assets/6552521/20685186/ab371c00-b5b3-11e6-8fe7-6b1ae87b57e0.png)
   
  ![Workspace view](https://cloud.githubusercontent.com/assets/6552521/20685216/ceed7aea-b5b3-11e6-8bc8-adc1c2ba542e.png)
  
  ![Updater](https://cloud.githubusercontent.com/assets/6552521/20685261/02161fe4-b5b4-11e6-8a6b-c068d1631d0f.png)
 
  ![Settings tab](https://cloud.githubusercontent.com/assets/6552521/20685274/0f7e197a-b5b4-11e6-9a10-aff112dae971.png)
  
</details>

### License
This project itself is licensed under the [Apache-2.0](https://opensource.org/licenses/Apache-2.0) license. This is also stated in the header of every file.
The used libraries aren't all licensed under Apache-2.0. You can find information about their licenses down below. With the use of the programm you accept all of them automaticially.
With your contribution you accept that your work is licensed automaticially under the Apache-2.0 too. However you still have your own copyright.

### Any trouble?
Head over to the [wiki page](https://github.com/chris579/YTMusicDownloader/wiki).

___

#### Used libraries
[MIT license](https://opensource.org/licenses/MIT):
- [MahApps.Metro](https://github.com/MahApps/MahApps.Metro) - Thanks to [punker76](https://github.com/punker76) for this awesome UI library!
- [NewtonSoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
- [MVVM Light](https://mvvmlight.codeplex.com/)

[MS-PL](https://opensource.org/licenses/MS-PL)
- [NAudio](https://github.com/naudio/NAudio)

[Apache-2.0](https://opensource.org/licenses/Apache-2.0):
- [RestSharp](https://github.com/restsharp/RestSharp)

[BSD-2-Clause](https://opensource.org/licenses/BSD-2-Clause)
- [VideoLibrary](https://github.com/jamesqo/libvideo)

[BSD-3-Clause](https://github.com/NLog/NLog)
- [NLog](https://github.com/NLog/NLog)

[LGPL-2.1](https://www.gnu.org/licenses/old-licenses/lgpl-2.1.en.html)
- [Taglib-Sharp](https://github.com/mono/taglib-sharp)

#### Found bugs?
Report them directly to the [issue tracker](https://github.com/chris579/YTMusicDownloader/issues).


#### Want to contribute?
Every contribution is highly appreciated. Feature requests are appreciated too but I can't promise that they will find their way to the final product because this is just a hobby project.

#### Thanks to
- [Dean](https://www.youtube.com/channel/UCBammpwwTteR-Ej5Kv0aHZA) for the awesome logo and design


#### About my motivation
I created this tool because tools out there lack the support to sync whole playlists without the need to download every song again.
You can image how annoing it is to download each song seperate from your playlist with a web converter or download your whole playlist again because you added some songs to it,
especially at a size of 100+ songs.

Some free tools out there also have inbuild advertising which I perceive as a nuisance factor.
I wanted to create a free (and open source) tool to offer everybody out there a smart and simple possibility to download their favourite music from YouTube
and of course to make (my own) life a whole lot easier.
