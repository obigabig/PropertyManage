using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{

    public class Contract
    {
        int contractID = 0;
        int statusID = 0;
        string title = string.Empty;
        int contracTypeID = 0;
        decimal totalValue = 0;
        DateTime? contractDate;
        int signCount = 0;

        
        public int ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        
        public int StatusID
        {
            get { return statusID; }
            set { statusID = value; }
        }
        
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        
        public int ContracTypeID
        {
            get { return contracTypeID; }
            set { contracTypeID = value; }
        }
        
        public decimal TotalValue
        {
            get { return totalValue; }
            set { totalValue = value; }
        }
        
        public DateTime? ContractDate
        {
            get { return contractDate; }
            set { contractDate = value; }
        }
        
        public int SignCount
        {
            get { return signCount; }
            set { signCount = value; }
        }

    }

    public class ContractDate
    {
        int contractID = 0;
        int no = 0;
        DateTime? redeemDate;
        DateTime? signDate;

        
        public int ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        
        public DateTime? RedeemDate
        {
            get { return redeemDate; }
            set { redeemDate = value; }
        }
        
        public DateTime? SignDate
        {
            get { return signDate; }
            set { signDate = value; }
        }
    }

    public class ContractMember
    {
        int contractID = 0;
        int memberID = 0;
        decimal values;

        
        public int ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        
        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }
        
        public decimal Value
        {
            get { return values; }
            set { values = value; }
        }
    }
}
