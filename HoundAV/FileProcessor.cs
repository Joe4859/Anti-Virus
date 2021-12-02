using System;

public class Class1
{
    public class FileProcessor
    {
        static int fileCount = 0;
        static Stopwatch stopwatch = new Stopwatch();
        public FileProcessor()
        {
            ProcessAllVolumes();
        }

        static void ProcessAllVolumes()
        {
            stopwatch.Start();
            foreach (string volume in Environment.GetLogicalDrives())
            {
                Console.WriteLine($"Drive {volume} has {ProcessAllFiles(volume)} files.");
                fileCount = 0;
            }
            stopwatch.Stop();
            Console.WriteLine($"Opperation completed in {stopwatch.Elapsed.TotalSeconds} seconds.");
        }

        static int ProcessAllFiles(string folder)
        {
            List<string> foundViruses = new List<string>();
            foreach (string file in Directory.GetFiles(folder))
            {
                fileCount++;
                try
                {
                    using (StreamReader stream = new StreamReader(file))
                    {
                        string read = stream.ReadToEnd();
                        string[] virus = new string[] { "trojan", "virus", "malware", "adware", "hacking", "hacker", "freeware", "RAT" };
                        foreach (string st in virus)
                        {
                            if (Regex.IsMatch(read, st))
                            {
                                foundViruses.Add(file);
                                Console.WriteLine($"Virus found in file {new FileInfo(file).Name}! Type: {st}");
                                Task.Delay(100).Wait();
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine($"Error checking file {new FileInfo(file).Name}.");
                }

            }
            foreach (string subDir in Directory.GetDirectories(folder))
            {
                try
                {
                    ProcessAllFiles(subDir);
                }
                catch
                {
                    // swallow errors.
                }
            }
            return fileCount;
        }
    }
}
}
