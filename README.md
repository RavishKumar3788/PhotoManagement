# PhotoManagement

I created this app for personal use because I had a large collection of photos and videos stored on Google Photos. Eventually, Google started showing storage full warnings. I had two accounts with almost 30 GB of photos and videos combined. I decided to download all of them and store them on a local hard drive. When I used Google Takeout to download my data, the resulting zip files included not only the media files but also some JSON and other metadata files. Since I didn’t want to copy these extra files, I created this app to move only the ".jpg", ".jpeg", ".gif", ".mp4", ".heic", ".mov", and ".png" files to my hard drive.

## Requirements

- Windows 10 or later
- .NET 8.0 (or compatible runtime)
- Google Takeout archive (for input files)

## Features

- Move only supported photo and video files to your hard drive
- Skip non-media and metadata files automatically
- Fast, parallel file operations for large collections
- Simple, user-friendly interface
- Progress bar and status updates during file moves

## How to Use

1. Download your photos and videos from Google Photos using Google Takeout.
2. Extract the downloaded zip files to a folder on your computer.
3. Open the PhotoManagement app.
4. Select the source folder containing your extracted files.
5. Select the target folder where you want to move your media files.
6. Click the "Move" button to start moving supported files.
7. Wait for the process to complete. The app will show progress and notify you when done.