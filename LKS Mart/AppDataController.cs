using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace LKS_Mart
{
    public class AppDataController
    {
        private string appDataFilePath = Application.StartupPath + "/LKSMart.appdata";

        public AppData GetAppData()
        {
            var appDataFile = File.ReadAllText(appDataFilePath);
            var appDataJSONObject = JsonSerializer.Deserialize<AppData>(appDataFile);

            return appDataJSONObject;
        }

        public void CreateAppDataFile()
        {
            if(!File.Exists(appDataFilePath))
            {
                var jsonObject = new AppData();
                File.WriteAllText(appDataFilePath, JsonSerializer.Serialize(jsonObject));
            }
        }

        public void LoginCustomer(int customerID)
        {
            var updatedAppData = GetAppData();
            updatedAppData.LoginCustomerID = customerID;

            File.WriteAllText(appDataFilePath, JsonSerializer.Serialize(updatedAppData));
        }
    }
}
