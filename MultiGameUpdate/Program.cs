using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace MultiGameUpdate
{
    class Program
    {
        static void Main( string[] args )
        {
            try { File.Delete( File.ReadAllText( @".\upf.m" ) ); } catch (Exception) { }
            try { File.Delete( @".\upf.m" ); } catch (Exception) { }
            dowload( "https://github.com/tyuXX/MultiGame/raw/master/MultiGame/bin/Release/Multi%20Game.exe", "MultiGame.exe" );
            Process.Start( @".\MultiGame.exe" );
        }
        static void dowload( string link, string name )
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile( link, name );
            }
        }
    }
}
