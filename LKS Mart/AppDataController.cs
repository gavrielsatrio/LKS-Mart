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

        public void SaveAppData(AppData appDataToSave)
        {
            File.WriteAllText(appDataFilePath, JsonSerializer.Serialize(appDataToSave));
        }

        public void CreateAppDataFile()
        {
            if(!File.Exists(appDataFilePath))
            {
                var jsonObject = new AppData()
                {
                    LoginCustomerID = -1,
                    CustomerCart = new List<CustomerCartItem>()
                };

                SaveAppData(jsonObject);
            }
        }

        public void LoginCustomer(int customerID)
        {
            var updatedAppData = GetAppData();
            updatedAppData.LoginCustomerID = customerID;

            SaveAppData(updatedAppData);
        }

        public void AddProductToCart(int productID, int qty)
        {
            var updatedAppData = GetAppData();
            updatedAppData.CustomerCart.Add(new CustomerCartItem
            {
                ProductID = productID,
                Qty = qty
            });

            SaveAppData(updatedAppData);
        }

        public void LogoutCustomer()
        {
            var updatedAppData = GetAppData();
            updatedAppData.LoginCustomerID = -1;
            updatedAppData.CustomerCart = new List<CustomerCartItem>();

            SaveAppData(updatedAppData);
        }

        public void DeleteProductFromCart(int productID)
        {
            var updatedAppData = GetAppData();
            var queryDelete = updatedAppData.CustomerCart.Find(x => x.ProductID == productID);
            updatedAppData.CustomerCart.Remove(queryDelete);

            SaveAppData(updatedAppData);
        }
    }
}
