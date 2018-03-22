using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GameLibrary

{
    class GameFactory
    {
        public List<Game> gameList;
        StreamWriter sw;
        XmlSerializer serial;
        StreamReader sr;
        const string FilePath = @"..\..\games.xml";


        public void CreateGameList()
        {
            gameList = new List<Game>();
            Game a = new Game("Hornets", "Bulldogs", 70, 50);
            gameList.Add(a);
            Game b = new Game("Lakers", "Celts", 30, 40);
            gameList.Add(b);
            Game c = new Game("Heat", "Bulls", 80, 50);
            gameList.Add(c);
            Game d = new Game("Knicks", "Warriors", 40, 60);
            gameList.Add(d);
            Game e = new Game("Kings", "Magic", 10, 20);
            gameList.Add(e);
            Game f = new Game("Timberwolves", "Hawks", 90, 80);
            gameList.Add(f);
            SerializeGameList();

        }

        public void SerializeGameList()
        {
            sw = new StreamWriter(FilePath);
            serial = new XmlSerializer(gameList.GetType());
            serial.Serialize(sw, gameList);
            sw.Close();
        }

        public void DeserializeGameList()
        {
            sr = new StreamReader(FilePath);
            serial = new XmlSerializer(gameList.GetType());
            gameList = (List<Game>)serial.Deserialize(sr);
            sr.Close();
        }
    }
}
