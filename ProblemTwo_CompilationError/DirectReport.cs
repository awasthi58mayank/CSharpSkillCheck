using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport : Employee
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(Employee managerEmpObj,string pCode) //:base(eID,eName,eLevel,eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
        public DirectReport(int eid,string eName,int eLevel,DateTime eDoj,Employee Reports,string ProjectCode)
        {
            this.EmpID = eid;
            this.EmpName = eName;
            this.EmpLevel = eLevel;
            this.DateOfJoining = eDoj;
            this.ReportsTo = Reports;
            this.ProjectCode = ProjectCode;

        }
    }
}
