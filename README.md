<div align="center">

<h1>MusicPlayer</h1>

<p>
  <strong>A Windows desktop music player developed in C# using Windows Forms and SQL Server. 
</strong>
</p>

<br>

<p> 
  <img
    src="https://img.shields.io/badge/build-passing-brightgreen?style=for-the-badge"
  >
  <img
    src="https://img.shields.io/badge/build-passing-brightgreen?style=for-the-badge"
  >
  <img
    src="https://img.shields.io/badge/build-passing-brightgreen?style=for-the-badge"
    alt="NumPy"
  >
  <img
    src="https://img.shields.io/badge/build-passing-brightgreen?style=for-the-badge"
  >
</p>

<p>
  <img
    src="https://img.shields.io/badge/DESKTOP-PYSIDE6-41CD52?style=for-the-badge&logo=qt&logoColor=white&labelColor=484848"
    alt="PySide6"
  >
  <img
    src="https://img.shields.io/badge/WEB-FASTAPI-009688?style=for-the-badge&logo=fastapi&logoColor=white&labelColor=484848"
    alt="FastAPI"
  >
</p>

</div>

---

## 📖 Project Overview

The application allows users to manage songs and playlists, play audio files, and store music-related information in a relational database.

## Technologies

- C#
- .NET / Windows Forms
- SQL Server Express
- SQL Server Management Studio
- Visual Studio
- Git / GitHub

## Features

### Music management
- Add songs to the database
- Import `.wav` audio files
- Automatically calculate song duration
- Store information such as title, artist, genre, release date and file path
- Display all available songs
- Delete songs
- View detailed information about a song

### Playlist management
- Create playlists
- Delete playlists
- Display playlists
- View songs belonging to a playlist
- Add and remove songs from playlists

### Music playback
- Play songs
- Stop and restart playback
- Navigate to the next and previous song
- Automatically move to the next song when playback ends
- Display the current song and artist
- Display the elapsed playback time

### Database
The application uses SQL Server to store:

- Users
- Songs
- Artists
- Playlists
- Connections between songs and playlists

The database structure uses primary and foreign keys to maintain relationships between entities.

## Project structure

```text
FinalMusicPlayer/
├── Database/
│   ├── CreateDatabase.sql
│   └── SeedData.sql
│
├── MusicPlayer/
│   ├── Form1.cs
│   ├── Service.cs
│   ├── Repository.cs
│   ├── SqlConn.cs
│   ├── PasswordHasher.cs
│   ├── AddSongForm.cs
│   ├── AddPlaylistForm.cs
│   ├── DeleteSongsForm.cs
│   ├── DisplaySongsForm.cs
│   ├── DisplayPlaylistForm.cs
│   ├── DisplaySongsFromPlaylist.cs
│   └── Media/
│       ├── Audio/
│       └── Images/
│
└── MusicPlayer.sln
