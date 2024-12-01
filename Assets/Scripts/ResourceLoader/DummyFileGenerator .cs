using System.Collections;
using UnityEngine;

namespace HikiNeetVisualNovel
{
    using System.IO;
    using System.Xml.Serialization;
    using UnityEngine;

    public class DummyFileGenerator : MonoBehaviour
    {
        [System.Serializable]
        public class TeamData
        {
            public string teamName;
            public Member[] members;
        }

        [System.Serializable]
        public class Member
        {
            public string name;
            public string role;
            public int experienceYears;
        }

        void Start()
        {
            // Define example data
            TeamData teamData = new TeamData
            {
                teamName = "Development Team",
                members = new[]
                {
                new Member { name = "Alice", role = "Programmer", experienceYears = 5 },
                new Member { name = "Bob", role = "Designer", experienceYears = 3 },
                new Member { name = "Charlie", role = "Artist", experienceYears = 4 }
            }
            };

            // Generate files
            GenerateJson(teamData);
            GenerateXml(teamData);
        }

        private void GenerateJson(TeamData teamData)
        {
            // Serialize data to JSON
            string json = JsonUtility.ToJson(teamData, true);

            // Define file path
            string jsonFilePath = Path.Combine(Application.dataPath, "TeamData.json");

            // Write to file
            File.WriteAllText(jsonFilePath, json);

            Debug.Log($"JSON file generated at: {jsonFilePath}");
        }

        private void GenerateXml(TeamData teamData)
        {
            // Serialize data to XML
            XmlSerializer serializer = new XmlSerializer(typeof(TeamData));
            string xmlFilePath = Path.Combine(Application.dataPath, "TeamData.xml");

            using (StreamWriter writer = new StreamWriter(xmlFilePath))
            {
                serializer.Serialize(writer, teamData);
            }

            Debug.Log($"XML file generated at: {xmlFilePath}");
        }
    }

}