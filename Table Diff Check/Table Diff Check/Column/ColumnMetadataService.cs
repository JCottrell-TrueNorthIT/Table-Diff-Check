using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Extensions;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Cross_Environment_Difference_Reviewer
{
    public class ColumnMetadataService
    {

        public static Dictionary<string, string> GetColumnMetadata(IOrganizationService service, string table, string column)
        {
            var metadata = service.GetEntityMetadata(table);

            var attribute = metadata.Attributes.FirstOrDefault(a => a.LogicalName == column);

            var columnData = new Dictionary<string, string>();

            foreach (var data in attribute.GetType().GetProperties())
            {
                var value = data.GetValue(attribute);

                if (value == null) continue;

                columnData.Add(data.Name, ColumnToString(value));

            }

            return columnData;
        }

        public static string ColumnToString(object columnData)
        {
            if (columnData is BooleanManagedProperty booleanManagedProperty) return booleanManagedProperty.Value.ToString();

            if (columnData is string[] strArr) return string.Join(", ", strArr);

            if (columnData is Label label) return label.LocalizedLabels.FirstOrDefault()?.Label;

            if (columnData is AttributeTypeDisplayName attributeTypeDisplayName) return attributeTypeDisplayName.Value;

            if (columnData is AttributeRequiredLevelManagedProperty attributeRequiredLevelManagedProperty) return attributeRequiredLevelManagedProperty.Value.ToString();

            if (columnData is OptionSetMetadata optionSetMetadata) return string.Join(", ", optionSetMetadata.Options.Select(o => o.Label.LocalizedLabels.FirstOrDefault()?.Label));

            if (columnData is StringFormatName stringFormatName) return stringFormatName.Value;

            return columnData.ToString();
        }

    }
}
