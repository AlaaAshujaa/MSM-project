using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDevexpress
{
    public partial class sync_msm : Form
    {
        public sync_msm()
        {
            InitializeComponent();
        }

        private void sync_msm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base.DataTable4' table. You can move, or remove it, as needed.
            this.dataTable4TableAdapter.Fill(this.data_base.DataTable4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Synchronization_Click(object sender, EventArgs e)
        {
            /*
             private async void SetIPConfig_Click()
     {
         Uri setIpUri = new Uri("http://192.168.10.1:8080/api/networking/ipV4config ");

         var ipConfiguration = new { AdapterName = "{A747DF73-160C-4B16-9694-FDE799043D9A}", IPAddress = "192.168.10.2", SubnetMask = "255.255.252.0", DefaultGateway = "192.168.10.1", PrimaryDNS = "192.168.10.10"};
         var contentString = JsonConvert.SerializeObject(ipConfiguration);

         Windows.Web.Http.HttpStringContent requestBody = new HttpStringContent(contentString, Windows.Storage.Streams.UnicodeEncoding.Utf8, "application/json");

         try
         {
             IBuffer dataBuffer = null;

             HttpBaseProtocolFilter httpFilter = new HttpBaseProtocolFilter();
             httpFilter.AllowUI = false;

             httpFilter.ServerCredential = new PasswordCredential();
             httpFilter.ServerCredential.UserName = "administrator";
             httpFilter.ServerCredential.Password = "p@ssw0rd";

             HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
             httpRequestMessage.Content = requestBody;
             httpRequestMessage.RequestUri = setIpUri;
             httpRequestMessage.Method = HttpMethod.Put;



             using (HttpClient client = new HttpClient(httpFilter))
             {

                 // Send the request
                 using (HttpResponseMessage response = await client.SendRequestAsync(httpRequestMessage))
                 {
                     if (!response.IsSuccessStatusCode)
                     {
                         System.Diagnostics.Debug.WriteLine(response.StatusCode);
                     }

                     if (response.Content != null)
                     {
                         using (IHttpContent messageContent = response.Content)
                         {
                             dataBuffer = await messageContent.ReadAsBufferAsync();
                         }
                     }
                 }
             }
         }
         catch (Exception ex)
         {
             System.Diagnostics.Debug.WriteLine(ex.Message);
         }
     }
*/
        }
    }
}
