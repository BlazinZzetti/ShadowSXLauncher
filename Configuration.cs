using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;

namespace ShadowSXLauncher
{
    public class Configuration
    {
        private static Configuration instance = null;

        private XmlDocument configurationXml;

        public bool UseModernUiControl;
        public int UiButtonDisplayIndex;
        private const string fileLocation = "Config.xml";

        public static readonly Dictionary<string, string> UiButtonStyles = new Dictionary<string, string>()
        {
            {"", "Default (GC)"},
            {"Xbox", "Xbox"},
            {"XboxOne", "Xbox One"},
            {"SteamDeck", "Steam Deck"},
            {"PS2", "PS2"},
            {"PS3", "PS3"},
        };

        private Configuration()
        {
            configurationXml = null;

            UseModernUiControl = false;
            UiButtonDisplayIndex = 0;
        }

        public static Configuration Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Configuration();
                }
                return instance;
            }
        }

        /// <summary>
        /// Load data from XML file to commands.
        /// </summary>
        public void LoadSettings()
        {
            if (configurationXml == null)
            {
                configurationXml = new XmlDocument();
                try
                {
                    configurationXml.Load(fileLocation);
                }
                catch(IOException e)
                {
                    //Create the file if it doesnt exist.
                    SaveSettings();
                }
            }

            foreach (XmlElement node in configurationXml.DocumentElement)
            {
                if (node.Name == "UseModernUIControl")
                {
                    UseModernUiControl = bool.Parse(node.InnerText);
                }

                if (node.Name == "UiButtonDisplayIndex")
                {
                    UiButtonDisplayIndex = int.Parse(node.InnerText);
                }
            }
        }

        public void SaveSettings()
        {
            configurationXml = new XmlDocument();

            var mainNode = configurationXml.CreateElement("Settings");

            var xmlElementUseModernUIControl = configurationXml.CreateElement("UseModernUIControl");
            xmlElementUseModernUIControl.InnerText = UseModernUiControl.ToString();

            var xmlElementUiButtonDisplayIndex = configurationXml.CreateElement("UiButtonDisplayIndex");
            xmlElementUiButtonDisplayIndex.InnerText = UiButtonDisplayIndex.ToString();

            configurationXml.AppendChild(mainNode);
            mainNode.AppendChild(xmlElementUseModernUIControl);
            mainNode.AppendChild(xmlElementUiButtonDisplayIndex);
            
            configurationXml.Save(fileLocation);
        }
    }
}