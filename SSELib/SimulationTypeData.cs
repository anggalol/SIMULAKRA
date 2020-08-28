using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;

#pragma warning disable CS0618, IDE0044

namespace SSELib
{
    public class SimulationTypeData : IXmlSerializable
    {
        //public const string FILE_PATH = @"%appdata%\Pak_Angga\data\std.xml";
        public const string FILE_PATH = "D:\\simpaileq\\asd.txt";
        private List<SimulationTypeBundle> _simulationTypeList;

        public SimulationTypeData()
        {
            _simulationTypeList = new List<SimulationTypeBundle>();
        }

        public void AppendSimulationTypeData(ISimulationType simulationType)
        {
            SimulationTypeBundle bundle = new SimulationTypeBundle(simulationType.GetType().Name, simulationType);
            if (Contains(bundle.Name))
                throw new ArgumentException("Cannot add this bundle because the data is already in the file.");

            _simulationTypeList.Add(bundle);
        }

        public void AppendSimulationTypeData(string name, float maxScore, string[] allowableQuestionType)
        {
            if (Contains(name))
                throw new ArgumentException("Cannot add this bundle because the data is already in the file.");

            CustomSimulation cs = new CustomSimulation()
            {
                MaxScore = maxScore,
                AllowableQuestionTypes = allowableQuestionType
            };
            SimulationTypeBundle bundle = new SimulationTypeBundle(name, cs);
            _simulationTypeList.Add(bundle);
        }

        public void AppendPrerequisitesSTD()
        {
            AppendSimulationTypeData(new UNBKSimulation());
            AppendSimulationTypeData(new UTBKSimulation());
            AppendSimulationTypeData(new AKMSimulation());
        }

        public void DeleteSimulationTypeData(SimulationTypeBundle bundle)
        {
            if (bundle.SimulationType.GetType() == typeof(UNBKSimulation)
                || bundle.SimulationType.GetType() == typeof(UTBKSimulation)
                || bundle.SimulationType.GetType() == typeof(AKMSimulation))
                throw new InvalidOperationException($"Cannot delete one of this simulation type: {nameof(UNBKSimulation)}, {nameof(UTBKSimulation)}, {nameof(AKMSimulation)}.");
            
            _simulationTypeList.Remove(bundle);
        }

        public SimulationTypeBundle GetSimulationTypeBundle(string name)
        {
            foreach (SimulationTypeBundle bundle in _simulationTypeList)
            {
                if (bundle.Name == name)
                    return bundle;
            }

            throw new ArgumentException($"There is no simulation type whose name is: {name}.");
        }

        public bool Contains(string name)
        {
            foreach (SimulationTypeBundle bundle in _simulationTypeList)
            {
                if (bundle.Name == name)
                    return true;
            }

            return false;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(nameof(SimulationTypeData));
            while (reader.IsStartElement(nameof(SimulationTypeBundle)))
            {
                Type type = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"));
                string name = reader.GetAttribute("name");

                XmlSerializer serializer = new XmlSerializer(type);
                reader.ReadStartElement(nameof(SimulationTypeBundle));
                SimulationTypeBundle bundle = new SimulationTypeBundle
                {
                    Name = name,
                    SimulationType = (ISimulationType)serializer.Deserialize(reader)
                };
                _simulationTypeList.Add(bundle);
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (SimulationTypeBundle bundle in _simulationTypeList)
            {
                writer.WriteStartElement(nameof(SimulationTypeBundle));
                writer.WriteAttributeString("AssemblyQualifiedName", bundle.SimulationType.GetType().AssemblyQualifiedName);
                writer.WriteAttributeString("name", bundle.Name);

                XmlSerializer serializer = new XmlSerializer(bundle.SimulationType.GetType());
                serializer.Serialize(writer, bundle.SimulationType);
                writer.WriteEndElement();
            }
        }
    }
}
