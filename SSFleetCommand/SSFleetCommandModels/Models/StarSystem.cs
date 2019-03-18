using SSFleetCommandModels.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System;

namespace SSFleetCommandModels.Models
{
    public class StarSystem : StarSystemCommon
    {
        public List<ResourceType> Resources { get; protected set; }
        public ShipType HostileTypes { get; protected set; }
        public int Level { get; }
        public static List<PropertyInfo> ResourceProperties => GetProperties();

        public StarSystem(DraftStarSystem source)
        {
            Name = source.Name;
            Level = int.Parse(source?.Level);
            System = source.System;

            Resources = new List<ResourceType>();
            ProcessElements(source);
            ProcessHostiles(source);
        }

        protected void ProcessHostiles(DraftStarSystem source)
        {
            if((source?.Battleship ?? "") == "X")
            {
                HostileTypes |= ShipType.Battleship;
            }

            if ((source?.Explorer ?? "") == "X")
            {
                HostileTypes |= ShipType.Explorer;
            }

            if ((source?.Interceptor ?? "") == "X")
            {
                HostileTypes |= ShipType.Interceptor;
            }

            if ((source?.Survey ?? "") == "X")
            {
                HostileTypes |= ShipType.Survey;
            }
        }

        protected void ProcessElements(DraftStarSystem source)
        {
            ResourceProperties.ForEach((prop) =>
            {
                var propValue = prop.GetValue(source);
                var elementType = ElementType.Crystal;
                var elementGrade = ElementGrade.None;
                if ((propValue?.ToString() ?? "") == "X")
                {
                    switch (prop.Name.Substring(prop.Name.Length - 1))
                    {
                        case "2":
                            elementType = Enum.Parse<ElementType>(prop.Name.Substring(0, prop.Name.Length - 1));
                            elementGrade = ElementGrade.Two;
                            break;
                        case "3":
                            elementType = Enum.Parse<ElementType>(prop.Name.Substring(0, prop.Name.Length - 1));
                            elementGrade = ElementGrade.Three;
                            break;
                        case "4":
                            elementType = Enum.Parse<ElementType>(prop.Name.Substring(0, prop.Name.Length - 1));
                            elementGrade = ElementGrade.Four;
                            break;
                        default:
                            elementType = Enum.Parse<ElementType>(prop.Name);
                            elementGrade = ElementGrade.None;
                            break;
                    }

                    Resources.Add(new ResourceType()
                    {
                        Type = elementType,
                        Grade = elementGrade
                    });
                }
            });
        }

        protected static List<PropertyInfo> GetProperties()
        {
            return typeof(DraftStarSystem).GetRuntimeProperties().ToList()
                .Where(prop => (
                    prop.Name.EndsWith("2")) 
                    || (prop.Name.EndsWith("3")) 
                    || (prop.Name.EndsWith("4"))
                    || (prop.Name.StartsWith("Tri"))
                    || (prop.Name.StartsWith("Par"))
                    || (prop.Name.StartsWith("Dil")))
                .ToList();
        }
    }
}
