using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Web_MenuDigital.Models;
using System.Text.Json;
using Web_MenuDigital.Repository;

namespace Web_MenuDigital.Services
{
    public class DataService
    {
        public enum CrudResult
        {
            Saved = 1,
            Error = 2,
            NotFound = 3,
        }

        public readonly string file = @"D:\\AngularProject\\Web_Digital_Menu\\Web_MenuDigital\\Web_MenuDigital\\data.txt";

        public CrudResult WriteData(List<Branch> list)
        {
            var strJson = new JsonSerializerOptions() { WriteIndented = true };
            var obj = JsonSerializer.Serialize<List<Branch>>(list, strJson);
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(obj);
            }
            return CrudResult.Saved;
        }
    }
}