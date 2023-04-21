namespace MultiGame;

internal static class rsmngr
{
    internal static List<ListedImage> ImageMap = new();
    internal static void RefreshImageMap()
    {
        if (Directory.Exists(resourcefolder))
        {
            foreach (string str in Directory.GetFiles(resourcefolder + @"\bitmap"))
            {
                ImageMap.Add(new()
                {
                    image = Image.FromFile(str),
                    index = str
                });
            }
        }
    }
}
internal struct ListedImage
{
    internal Image image;
    internal string index;
}
internal enum ImageMapIndexes
{

}
