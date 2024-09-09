using EventsAndDelegates;

MusicPlayer musicPlayer = new MusicPlayer();

Subscriber subscriber1 = new Subscriber("User1");

Subscriber subscriber2 = new Subscriber("User2");

musicPlayer.SongPlayed += subscriber1.SongPlayedHandler;

musicPlayer.SongPaused += subscriber1.SongPausedHandler;

musicPlayer.SongStopped += subscriber1.SongStoppedHandler;

musicPlayer.SongSkipped += subscriber1.SongSkippedHandler;

musicPlayer.SongPlayed += subscriber2.SongPlayedHandler;

musicPlayer.SongPaused += subscriber2.SongPausedHandler;

musicPlayer.SongStopped += subscriber2.SongStoppedHandler;

musicPlayer.SongSkipped += subscriber2.SongSkippedHandler;

while (true)

{

    Console.WriteLine("\nEnter the action (play, pause, stop, skip) or 'exit' to end:");

    string action = Console.ReadLine().ToLower();

    if (action == "exit")

        break;

    Console.WriteLine("Enter the song title:");

    string songTitle = Console.ReadLine();

    switch (action)

    {

        case "play":

            musicPlayer.Play(songTitle);

            break;

        case "pause":

            musicPlayer.Pause(songTitle);

            break;

        case "stop":

            musicPlayer.Stop(songTitle);

            break;

        case "skip":

            Console.WriteLine("Enter the next song title:");

            string nextSongTitle = Console.ReadLine();

            musicPlayer.Skip(songTitle, nextSongTitle);

            break;

        default:

            Console.WriteLine("Invalid action. Please enter play, pause, stop, skip, or exit.");

            break;

    }

}

        