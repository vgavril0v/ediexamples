using System;
using System.Collections.Generic;
using System.Linq;
using Parser2.LenovoApi;

namespace Parser2.InventoryReco
{
    public class InventoryRecoBuilder
    {
        private Dictionary<(string materialNumber, string plant, string location), int> inventoryData =
            new Dictionary<(string materialNumber, string plant, string location), int>();

        public InventoryRecoBuilder WithMaterial(string materialNumber, string plant, string location, int qty)
        {
            var key = (materialNumber, plant, location);
            if (inventoryData.TryGetValue(key, out var q))
            {
                inventoryData[key] = q + qty;
            }
            else
            {
                inventoryData.Add(key, qty);
            }
            return this;
        }

        public InventoryDataLine[] BuildInventoryData()
        {
            return inventoryData.Select(d => new InventoryDataLine
            {
                create_date = DateTime.UtcNow.ToString("yyyyMMdd"),
                create_time = DateTime.UtcNow.ToString("HHmmss"),
                timezone = "UTC+00",
                unit_of_measurement = "EA",
                material_number = d.Key.materialNumber,
                plant = d.Key.plant,
                location = d.Key.location,
                quantity = d.Value.ToString()
            }).ToArray();
        }
    }
}