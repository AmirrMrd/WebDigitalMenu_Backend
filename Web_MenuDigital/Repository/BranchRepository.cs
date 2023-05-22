using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Web.Http;
using Web_MenuDigital.FileUploadExtension;
using Web_MenuDigital.Models;
using Web_MenuDigital.Services;

namespace Web_MenuDigital.Repository
{
    
    public class BranchRepository
    {
        public readonly string file = AppDomain.CurrentDomain.BaseDirectory + @"log\\data.txt";
        public readonly string imageFolder = AppDomain.CurrentDomain.BaseDirectory +  @"log\";
        public enum RepositoryResult
        {
            created = 1,
            NotFound = 2,
            Error = 3,
            Updated = 4,
            Deleted = 5,
        }



        public List<Branch> GetAllBranches() 
        {
            List<Branch> branchlist = new List<Branch>();
            //FileStream f = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            var des_data = JsonSerializer.Deserialize<List<Branch>>(reader.ReadToEnd());
            branchlist = des_data;
            reader.Close();
            return branchlist;
        }

        public Branch GetBranchById(int branchId)
        {
            return null;
        }

        public Branch CreateBranch(Branch branch)
        {
            if (branch == null)
            {
                return null;
            }
            else
            {
                if (!string.IsNullOrEmpty(branch.ImageBase64))
                {
                    var imageFile = ImageUploaderExtension.Base64ToImage(branch.ImageBase64);
                    var imageName = Guid.NewGuid().ToString("N") + ".jpeg";
                    imageFile.AddImageToServer(imageName, imageFolder);
                }
                List<Branch> branchlist = new List<Branch>();
                StreamReader reader = new StreamReader(file);
                var des_data = JsonSerializer.Deserialize<List<Branch>>(reader.ReadToEnd());
                branchlist = des_data;
                reader.Close();
                branchlist.Add(branch);
                DataService crud = new DataService();
                crud.WriteData(branchlist);
                return branch;

            }
        }

        public Branch UpdateBranch(int id, string value)
        {
            //if (branch == null)
            //{
            //    return null;
            //}
            //else
            //{
            //    Branch branch1 = new Branch();
            //    branch.BranchId = branch1.BranchId;
            //    branch.BranchName = branch1.BranchName;
            //    branch.BranchIpAddress = branch1.BranchIpAddress;
            //    branch.BranchPortNumber = branch1.BranchPortNumber;
            //    return branch1;
            //}
            return null;
        }

        public string DeleteBranch (int id)
        {
            return "شعبه انتخاب شده حذف شد";
        }
    }
}



