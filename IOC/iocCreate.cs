using System;
using System.Collections.Generic;
using System.Linq;
using IDAO;
using DAO;
using IBLL;
using Model;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;

namespace IOC
{
    public class iocCreate
    {
        public static IStudentDAO<StudentModel> CreateStudentDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IStudentDAO<StudentModel>,StudentDAO>();
            return ioc.Resolve<IStudentDAO<StudentModel>>();
        }
        public static IStudentBLL<StudentModel> CreateStudentBLL()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"E:\ASP.NET\MVC\HR\WebApplication1\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<IStudentBLL<StudentModel>>("IStudentBLL");
        }
    }
}
