// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class DataTable_internal
    {
        internal static DataTable_internal DeserializeDataTable_internal(JsonElement element)
        {
            int rows = default;
            int columns = default;
            IReadOnlyList<DataTableCell_internal> cells = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rows"))
                {
                    rows = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columns"))
                {
                    columns = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cells"))
                {
                    List<DataTableCell_internal> array = new List<DataTableCell_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataTableCell_internal.DeserializeDataTableCell_internal(item));
                    }
                    cells = array;
                    continue;
                }
            }
            return new DataTable_internal(rows, columns, cells);
        }
    }
}
