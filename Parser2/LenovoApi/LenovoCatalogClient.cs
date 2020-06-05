using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace Parser2.LenovoApi
{
    public class LenovoCatalogClient
    {
       
        public static async Task<Dictionary<string, (Materiallist material, Materialplantlist plant, Materialdescribelist description)>>
            GetLenovoMaterials(IEnumerable<string> materialNumbers,
            string plant)
        {
            var result = new Dictionary<string, (Materiallist material, Materialplantlist plant, Materialdescribelist description)>();
            var client = new HttpClient();

            // client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            var materlNumberSet = new HashSet<string>(materialNumbers);
            var uri = new Uri(
                "https://api-cn-t.lenovo.com/uat/v1.0/supply_chain/masterdata/plant_material_description/queryByPlant");

            var data = "{\"clientList\": [\"301\"],\"customsMaterialNumberList\": [" + string.Join(",",
                           materlNumberSet
                               .Select(id => "\"" + id.Replace("-", "") + "\"")) +
                       "],\"languageCodeList\": [\"E\"],\"plantList\": [\"" + plant + "\"]} ";
            var content = new StringContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var token = await LenovoTokenClient.GetTokenFromCache();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            CatalogResponse obj = null;
            while (obj == null || (obj.code == "-1" && obj.msg.Contains("Null")))
            {
                var res = await (await client.PostAsync(uri, content))
                    .Content.ReadAsStringAsync();
                obj = JsonConvert.DeserializeObject<CatalogResponse>(res);
            }

            foreach (var materialNumber in materlNumberSet)
            {
                var material = obj.result.materialList.FirstOrDefault(m => m.materialNumber == materialNumber);
                if (material == null)
                {
                    continue;
                }
                result.Add(materialNumber, (material, 
                    obj.result.materialPlantList.FirstOrDefault(p => p.materialNumber == materialNumber),
                    obj.result.materialDescribeList.FirstOrDefault(d => d.materialNumber == materialNumber)));
            }

            return result;
        }

    }


    public class Token
    {
        public string access_token { get; set; }
        public string scope { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }



    public class CatalogResponse
    {
        public string code { get; set; }
        public string msg { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public Materialplantlist[] materialPlantList { get; set; }
        public Materiallist[] materialList { get; set; }
        public Materialdescribelist[] materialDescribeList { get; set; }
    }

    public class Materialplantlist
    {
        public string id { get; set; }
        public string ternativeBillsMaterialMethod { get; set; }
        public string replacementPart { get; set; }
        public string unitOfIssue { get; set; }
        public string procurementType { get; set; }
        public string lotSize { get; set; }
        public string mrpType { get; set; }
        public string mrpController { get; set; }
        public int productionTime { get; set; }
        public string purchasingGroup { get; set; }
        public string stockDeterminationGroup { get; set; }
        public string jitRelevantDeliverySchedules { get; set; }
        public string schedulingMarginFloats { get; set; }
        public string planningTimeFence { get; set; }
        public string sourceListRequirement { get; set; }
        public string criticalPart { get; set; }
        public string loadingGroup { get; set; }
        public string productCostingLotSize { get; set; }
        public string issueStorageLocation { get; set; }
        public float costingLotSize { get; set; }
        public string abcIndicator { get; set; }
        public string client { get; set; }
        public string transMaterialGroup { get; set; }
        public string materialNumber { get; set; }
        public string materialFreightGroup { get; set; }
        public string plantMaterialStatus { get; set; }
        public string checkingGroup { get; set; }
        public string doNotCost { get; set; }
        public int plannedDeliveryDays { get; set; }
        public string profitCenter { get; set; }
        public string backflush { get; set; }
        public string bulkMaterial { get; set; }
        public string serialNumberProfile { get; set; }
        public string specialProcurementType { get; set; }
        public string commodityCode { get; set; }
        public string configurableMaterial { get; set; }
        public string controlCode { get; set; }
        public string planningGroup { get; set; }
        public float shippingProcessingTime { get; set; }
        public float shippingSetupTime { get; set; }
        public string plant { get; set; }
        public string customsMaterialNumber { get; set; }
        public string ibmsnapLogmarker { get; set; }
        public string ibmsnapOperation { get; set; }
        public int masterOrderShowId { get; set; }
    }

    public class Materiallist
    {
        public string id { get; set; }
        public string changedBy { get; set; }
        public string materialCategory { get; set; }
        public string oldMaterialNumber { get; set; }
        public float width { get; set; }
        public float grossWeight { get; set; }
        public string ean { get; set; }
        public string eanNumber { get; set; }
        public string createdBy { get; set; }
        public string createdOn { get; set; }
        public string externalMaterialGroup { get; set; }
        public string weightUnit { get; set; }
        public string size { get; set; }
        public float height { get; set; }
        public string lastDate { get; set; }
        public float length { get; set; }
        public string deletionDate { get; set; }
        public string deletionFlagClientLevel { get; set; }
        public string matlGrpPackMatls { get; set; }
        public string client { get; set; }
        public string materialGroup { get; set; }
        public string materialNumber { get; set; }
        public string industrySector { get; set; }
        public string unitDimension { get; set; }
        public string baseUnit { get; set; }
        public string manufacturerPartNumber { get; set; }
        public string materialType { get; set; }
        public string genItemCatGrp { get; set; }
        public string industryStandard { get; set; }
        public string qualFreeGoodsDis { get; set; }
        public float netWeight { get; set; }
        public string eanCategory { get; set; }
        public string productHierarchy { get; set; }
        public string serializationLevel { get; set; }
        public string division { get; set; }
        public string transportationGroup { get; set; }
        public string volumeUnit { get; set; }
        public float volume { get; set; }
        public string documentNumber { get; set; }
        public string locationCode { get; set; }
        public string productFamily { get; set; }
        public string usageCode { get; set; }
        public string ibmsnapLogmarker { get; set; }
        public string ibmsnapOperation { get; set; }
        public int masterOrderShowId { get; set; }
    }

    public class Materialdescribelist
    {
        public string id { get; set; }
        public string materialDescriptionUppercase { get; set; }
        public string materialDesc { get; set; }
        public string client { get; set; }
        public string materialNumber { get; set; }
        public string languageCode { get; set; }
        public string ibmsnapLogmarker { get; set; }
        public string ibmsnapOperation { get; set; }
        public int masterOrderShowId { get; set; }
    }

}