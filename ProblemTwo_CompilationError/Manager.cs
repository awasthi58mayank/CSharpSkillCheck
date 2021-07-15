using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager : Employee
    {
        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }

        public Manager(List<Employee> drEmployeesLst, string cCode) //:base(eID, eName, eLevel, eDoJ)
        {
            DirectReports = drEmployeesLst;
            CostCode = cCode;

        }
        public Manager(int eid,string eName,int  eLevel,DateTime eDoj,List<Employee> DirectReports,string CostCode){
            this.EmpID = eid;
            this.EmpName = eName;
            this.EmpLevel = eLevel;
            this.DateOfJoining = eDoj;
            this.DirectReports = DirectReports;
            this.CostCode = CostCode;



        }
        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}
