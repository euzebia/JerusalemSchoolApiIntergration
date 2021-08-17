using System;
using System.Text.Json;
namespace Jerusalem
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic bll= new BusinessLogic();
            Console.WriteLine("--------------- Jerusalem School Api Intergration -------------");
            string url="https://tasks.schoolmonitor.net/recieve_payments/";
            string token ="e54d301c9563fd4279dbb50d3be7a8460863ecac";
            PaymentInfo payment = new PaymentInfo(){
                                                     School_name="Namagabi ss",Teller="none",
                                                     Student_name="Joyce",Student_no="893837",
                                                     Student_class="s.4",Transaction_amount="1000",
                                                     Transaction_status="POSTED",Transaction_id="393737",
                                                     Bank_id="393737",Receipt_no="215474,6081",
                                                     Channel="MOBILE",Agent_code="MTN",
                                                     School_type="PRIMARY",Recorded_date="9/16/2020  11:20:24 AM",
                                                     Transaction_date="9/16/2020  12:00:00 AM"
                                                     };
            string postData = JsonSerializer.Serialize(payment);
   
            BusinessLogic.HttpPost(url,token,postData);
        }
    }
}
