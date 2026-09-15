<div align="center">

<h1>MusicPlayer</h1>

<p>
  <strong>A Windows desktop music player developed in C# using Windows Forms and SQL Server (ongoing project).</strong><br>
  <i>MusicPlayer is written in C#, using .NET and Windows Forms, with SQL Server as the database.</i>
</p>

<br>

<p>
  <img
    src="https://img.shields.io/badge/C%23-.NET-144B4E?style=for-the-badge&logo=dotnet&logoColor=white"
    alt="C# / .NET"
  >
  <img
    src="https://img.shields.io/badge/WINDOWS-WINFORMS-A8E1DE?style=for-the-badge&logo=windows&logoColor=144B4E"
    alt="Windows Forms"
  >
  <img
    src="https://img.shields.io/badge/DATABASE-SQL%20SERVER-50B4B2?style=for-the-badge&logo=microsoftsqlserver&logoColor=white"
    alt="SQL Server"
  >
  <img
    src="https://img.shields.io/badge/IDE-VISUAL%20STUDIO-144B4E?style=for-the-badge&logo=visualstudio&logoColor=white"
    alt="Visual Studio"
  >
</p>

</div>
---

## 📖 Project Overview

The application allows users to manage songs and playlists, play audio files, and store music-related information in a relational database.
The core music-player functionalities include database storage, song and playlist management, audio playback, and UI interaction.
Authentication/security features are currently being added, and some playback/playlist behaviour may still require refinement.

## Technologies

- C#
- .NET / Windows Forms
- SQL Server Management Studio
- Visual Studio
- Git / GitHub

### Music management
- Add songs to the database (Import `.wav` audio files)
- Automatically calculate song duration
- Store information such as title, artist, genre, release date and file path
- Display all available songs
- Delete songs
- View detailed information about a song

### Playlist management
- Create playlists
- Delete playlists
- Display playlists
- Display songs belonging to a playlist
- Manage playlists (add and remove songs from playlists)

### Music playback
- Play/pause songs
- Navigate to the next and previous song
- Automatically move to the next song when playback ends (still needs checking)
- Display the current song and artist
- Display the elapsed playback time

### Database
The application uses SQL Server to store:

- Users
- Songs
- Artists
- Playlists
- Connections between songs and playlists

> The database structure uses primary and foreign keys to maintain relationships between entities.

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
|   ... (the rest is to be added)
│   └── Media/
│       ├── Audio/
│       └── Images/
│
└── MusicPlayer.sln
```

## Architecture
The project separates the main responsibilities into several components:
- Repository – communicates with the database and manages data access.
- Service – contains application logic and coordinates operations between the UI and repository.
- Forms – provide the graphical user interface.
- SqlConn – handles communication with SQL Server.
- PasswordHasher – provides password hashing functionality for user authentication.

## Database
The main database entities are:
- Users
- Songs
- Artists
- Playlists
- Connections
> Playlists are associated with users, while songs and playlists are connected through the Connections table.

## Security
User authentication is currently being implemented.
The project uses password hashing and a unique salt instead of storing passwords directly. Password hashing is implemented using PBKDF2.
The authentication system is intended to provide:
- user registration
- login
- password verification


## Audio files
For portability, the application looks for audio files inside:
```MusicPlayer/Media/Audio/```
The repository also contains 2 demo audio files. 
The complete personal music collection is not included in the repository (have been manually added though the Import song functionality)

