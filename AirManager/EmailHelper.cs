using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace AirManager {
    public class EmailHelper {
        private static string senderEmail;
        private static string senderPassword;
        private static string senderHost;
        private static int senderPort;
        private static bool senderSSL;

        static EmailHelper() {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json");

            IConfiguration configuration = builder.Build();

            senderEmail = configuration["EmailSettings:SenderEmail"];
            senderPassword = configuration["EmailSettings:SenderPassword"];
            senderHost = configuration["EmailSettings:SenderHost"];
            senderPort = int.Parse(configuration["EmailSettings:SenderPort"]);
            senderSSL = bool.Parse(configuration["EmailSettings:SenderSSL"]);
        }

        public static bool SendEmail(string receiverEmail, string subject, string messageBody) {
            try {
                SmtpClient smtpClient = new SmtpClient(senderHost, senderPort);
                smtpClient.EnableSsl = senderSSL;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                MailMessage mailMessage = new MailMessage(senderEmail, receiverEmail, subject, "");

                mailMessage.Body = messageBody;
                mailMessage.IsBodyHtml = true;

                smtpClient.Send(mailMessage);
                return true;
            } catch (Exception) {
                return false;
            }
        }
        public static void sendVerificationEmail(string receiverEmail, string receiverName, string verificationCode) {
            string body = "<!DOCTYPE html>";

            body += "<html lang=\"ro\">";
            body += "<head>";
            body += "    <meta charset=\"utf-8\">";
            body += "    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">";
            body += "    <style>";
            body += "        body { font-family: Arial, sans-serif; margin: 0; padding: 0; }";
            body += "        .container { max-width: 600px; margin: 0 auto; padding: 20px; }";
            body += "        .header { text-align: center; padding: 10px; margin-bottom: 15px; }";
            body += "        .header h1 { color: #191654; display: inline-block; margin-left: 15px; }";
            body += "        .header img { display: inline-block; vertical-align: middle; }";
            body += "        .content { background-color: #f2f2f2; padding: 20px; }";
            body += "        .content h2 { color: #43c6ac; }";
            body += "        .content p { color: #191654; }";
            body += "        .footer { background-color: #191654; color: #ffffff; text-align: center; font-size: 12px; padding: 20px; }";
            body += "    </style>";
            body += "    <title>AirManager</title>";
            body += "</head>";
            body += "<body>";
            body += "    <div class=\"container\">";
            body += "        <div class=\"header\">";
            body += "            <img src=\"https://i.imgur.com/qW5Udoj.png\" alt=\"Air Manager\" style=\"width: 40px; height: 40px;\">";
            body += "            <h1>AirManager</h1>";
            body += "        </div>";
            body += "        <div class=\"content\">";
            body += "            <h2>Hello, " + receiverName + "!</h2>";
            body += "            <p> Your verification code is: <b>" + verificationCode + "</b></p>";
            body += "            <p> Please enter this code in the verification window.</p>";
            body += "            <p> If you did not request this code, please ignore it.</p>";
            body += "        </div>";
            body += "        <footer class=\"footer\">&copy; 2023 AirManager. All rights reserved.</footer>";
            body += "    </div>";
            body += "</body>";
            body += "</html>";

            SendEmail(receiverEmail, "AirManager: Verification code", body);
        }

        public static void sendWelcomeEmail(string receiverEmail, string receiverName) {
            string body = "<!DOCTYPE html>";

            body += "<html lang=\"ro\">";
            body += "<head>";
            body += "    <meta charset=\"utf-8\">";
            body += "    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">";
            body += "    <style>";
            body += "        body { font-family: Arial, sans-serif; margin: 0; padding: 0; }";
            body += "        .container { max-width: 600px; margin: 0 auto; padding: 20px; }";
            body += "        .header { text-align: center; padding: 10px; margin-bottom: 15px; }";
            body += "        .header h1 { color: #191654; display: inline-block; margin-left: 15px; }";
            body += "        .header img { display: inline-block; vertical-align: middle; }";
            body += "        .content { background-color: #f2f2f2; padding: 20px; }";
            body += "        .content h2 { color: #43c6ac; }";
            body += "        .content p { color: #191654; }";
            body += "        .footer { background-color: #191654; color: #ffffff; text-align: center; font-size: 12px; padding: 20px; }";
            body += "    </style>";
            body += "    <title>AirManager</title>";
            body += "</head>";
            body += "<body>";
            body += "    <div class=\"container\">";
            body += "        <div class=\"header\">";
            body += "            <img src=\"https://i.imgur.com/qW5Udoj.png\" alt=\"Air Manager\" style=\"width: 40px; height: 40px;\">";
            body += "            <h1>AirManager</h1>";
            body += "        </div>";
            body += "        <div class=\"content\">";
            body += "            <h2>Hello, " + receiverName + "!</h2>";
            body += "            <p> Welcome to AirManager!</p>";
            body += "            <p> We are glad to have you as a member of our community.</p>";
            body += "            <p> If you have any questions, please contact us at <a href=\"mailto:airmanager@mihainiculai.ro\"> here.</a></p>";
            body += "            <p> Thank you for choosing us!</p>";
            body += "            <br>";
            body += "            <p> AirManager Team</p>";
            body += "        </div>";
            body += "        <footer class=\"footer\">&copy; 2023 AirManager. All rights reserved.</footer>";
            body += "    </div>";
            body += "</body>";
            body += "</html>";

            SendEmail(receiverEmail, "AirManager: Welcome", body);
        }
    }
}
