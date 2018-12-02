using ChargeMate.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChargeMate
{
    public partial class findmate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PLATE"] != null)
            {
                lblPlate.Text = Session["PLATE"].ToString();
                cardResult.Style.Clear();
                btnFind.Enabled = false;
            }
            Timer_Tick(null, null);
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                SSDCARE.WebService1SoapClient service = new SSDCARE.WebService1SoapClient();
                SSDCARE.Cars request = new SSDCARE.Cars();
                SSDCARE.Cars[] response = service.FindNearestCar(30, 40, 20);
                SSDCARE.Cars car = response.First();

                Session["PLATE"] = car.RegisterId;

                lblPlate.Text = car.RegisterId;
                cardResult.Style.Clear();
                btnFind.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SSDCARE.WebService1SoapClient asd = new SSDCARE.WebService1SoapClient();
            string charge = asd.getBatteryCharge();
            prg.Style.Value = "width:" + charge + "%";
            //prg. = "width:" + response.Body.getBatteryChargeResult + "%";
            prg.InnerText = charge + "%";

            //                        < div id = "prg" runat = "server" class="progress-bar bg-danger progress-bar-striped progress-bar-animated"
            //role="progressbar"
            //                style="width: 20%" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
            //                20%
            //            </div>
        }
    }
}