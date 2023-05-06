using System.Collections.Generic;
using Web_MenuDigital.Models;
using Web_MenuDigital.Repository;

namespace Web_MenuDigital.Services
{
    public class BranchCrudService
    {
        public List<Branch> GetAllBranches()
        {
            BranchRepository repository = new BranchRepository();
            return repository.GetAllBranches();
        }

        public Branch GetBranchById(int branchId)
        {
            BranchRepository repository = new BranchRepository();
            return repository.GetBranchById(branchId);
        }

        public Branch CreateBranch(Branch branch)
        {
            BranchRepository repository = new BranchRepository();
            return repository.CreateBranch(branch);
        }

        public Branch UpdateBranch(int id , string value)
        {
            BranchRepository repository = new BranchRepository();
            return repository.UpdateBranch(id, value);
        }

        public string DeleteBranch(int id)
        {
            BranchRepository repository = new BranchRepository();
            return repository.DeleteBranch(id);
        }
    }
}