using System;

namespace GameLib
{
    public enum Level
    {
        Kolay,
        Orta,
        Zor
    }
    public class GameInfo
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Level Seviye { get; set; }
    }
}
//dosya derlendiğinde dosya uzantısı dll olur. GameLib referenca ettik oyun projesinin libraryden haberi var oldu
