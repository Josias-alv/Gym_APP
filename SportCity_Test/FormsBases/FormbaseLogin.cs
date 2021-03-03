using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCity_Test.FormsBases
{
    public partial class FormbaseLogin : Form
    {
        public FormbaseLogin()
        {
            InitializeComponent();
        }
        public static string SHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
	    public static string sha256(string randomString)
        {
            var crypt = new SHA256Managed();
			var hash = new StringBuilder();
			byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
			foreach (byte theByte in crypto)
			{
				hash.Append(theByte.ToString("x2"));
			}
			return hash.ToString();
		}
        public static DataSet DataTabletoDataset(DataTable dt)
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dt);
            return dataSet;
        }
    }
}
