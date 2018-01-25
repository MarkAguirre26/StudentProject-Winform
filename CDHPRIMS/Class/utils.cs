using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDHPRIMS.Class
{
  public  class utils
    {
        public static string connectionString = "Data Source = .\\SQLEXPRESS; Initial Catalog = CalbayogHospitalSystem; Integrated Security = True;User ID=sa;Password=sasa";
        public static string AppPath = (Path.GetDirectoryName(Application.StartupPath));
    }
}
