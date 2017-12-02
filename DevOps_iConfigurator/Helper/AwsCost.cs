using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DevOps_iConfigurator.Models;
using System.Web;
using System.Text.RegularExpressions;


namespace DevOps_iConfigurator.Helper
{
    public class AwsCost
    {
        public AwsCost()
        {
            WebClient n = new WebClient();
            //var csv = n.DownloadString(@"https://pricing.us-east-1.amazonaws.com/offers/v1.0/aws/AmazonEC2/current/ap-south-1/index.csv");
            n.DownloadFile("https://pricing.us-east-1.amazonaws.com/offers/v1.0/aws/AmazonEC2/current/ap-south-1/index.csv", HttpContext.Current.Server.MapPath("~/CSV/mum_region_index.csv"));
        }
        public String GetAwsPrice(string OSType, string InstanceType)
        {
            AwsCost awsObj = new AwsCost();
            List<CSV_model> PriceList = new List<CSV_model>();
            //string file = ("D:/Task/AWS-Price-list api/Api_For_CSV_format/Api_For_CSV_format/CSV/mumbai_region.csv");
            string file = HttpContext.Current.Server.MapPath("~/CSV/mum_region_index.csv");
            //string CSV = Convert.ToString(data);
            string csvData = System.IO.File.ReadAllText(file);

            foreach (string row in csvData.Split('\n').Skip(5))
            {

                if (!string.IsNullOrEmpty(row))
                {

                    string line = row;
                    PriceList.Add(new CSV_model
                    {

                        Instance_Type = Regex.Split(row, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)")[18].Replace("\"", ""),
                        OS_System = Regex.Split(row, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)")[37].Replace("\"", ""),
                        Tenancy = Regex.Split(row, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)")[35].Replace("\"", ""),
                        Price_per_Unit = Regex.Split(row, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)")[9].Replace("\"", ""),
                        Unit = Regex.Split(row, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)")[8].Replace("\"", ""),
                        Termtype = Regex.Split(row, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)")[3].Replace("\"", ""),

                    });

                }
            }

                var Result = PriceList.Where(C => C.OS_System == (OSType) && C.Instance_Type == (InstanceType) && C.Tenancy == ("Shared") && C.Termtype == ("OnDemand")).ToList();
        
                return "$" + String.Format("{0:0.0000}",Convert.ToDouble (Result[0].Price_per_Unit)).ToString() +  " Per "  + Result[0].Unit.ToString();
         }
        
        
    }
}