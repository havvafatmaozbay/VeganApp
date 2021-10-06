using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VeganYemekApp
{
    public class SqlBaglanti
    {
    
            public SqlConnection baglanti()
            {
                SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OQ1P4OP\\SQLEXPRESS;Initial Catalog=düzeltmeVeganYemekArifi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                baglan.Open();
                return baglan;
            }
        }
    }

