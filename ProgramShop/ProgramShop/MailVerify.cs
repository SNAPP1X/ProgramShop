using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramShop
{
    internal class MailVerify
    {
        #region    Функция проверки почтового ящика
        /// <summary>
        /// Создание случайный код подтверждения
        /// </summary>
        /// <param name="CodeLength"> Длина кода проверки </ param>
        public static string CreateRandomMailCode(int CodeLength)
        {
            int randNum;
            char code;
            string randomCode = String.Empty;// Случайный код подтверждения

            //// Создание случайный код подтверждения для определенной длины       
            // случайные случайные = новые случайные (); // генерируют случайные номера объектов
            for (int i = 0; i < CodeLength; i++)
            {
                // генерируют 6 случайных чисел, используя GUID      
                byte[] buffer = Guid.NewGuid().ToByteArray();// Generate байтовые массивы
                int seed = BitConverter.ToInt32(buffer, 0);// преобразуйте байтовый массив в целое число, используя метод bitconvert
                Random random = new Random(seed);// как случайное семя как сгенерированное целое число
                randNum = random.Next();

                //randNum = random.Next();                
                if (randNum % 3 == 1)
                {
                    code = (char)('A' + (char)(randNum % 26));// Случайные заглавные буквы
                }
                else if (randNum % 3 == 2)
                {
                    code = (char)('a' + (char)(randNum % 26));// случайные строчные буквы
                }
                else
                {
                    code = (char)('0' + (char)(randNum % 10));// Случайное число
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }


        /// <summary>
        /// Отправить код подтверждения почты
        /// </summary>
        /// <param name = "MyeMailAddress"> Адрес электронной почты отправителя </ params>
        /// <param name = "ReceMailAddress"> Адрес электронной почты получателя </ params>
        /// <имя парамента = "Тема"> Почтовая тема </ param>
        /// <param name = "mailcontent"> Содержание почты </ param>
        /// <param name = "authovizateCode"> Код авторизации почтового ящика </ param>
        /// <returns></returns>
        public static bool SendMailMessage(string MyEmailAddress, string RecEmailAddress, string Subject, string Body, string AuthorizationCode)
        {

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(MyEmailAddress);// адрес электронной почты отправителя
            mail.To.Add(new MailAddress(RecEmailAddress));// адрес электронной почты получателя
            mail.Subject = Subject;// Название почты
            mail.Body = Body;  // Содержание электронной почты  
            mail.Priority = MailPriority.High;// Приоритет

            SmtpClient client = new SmtpClient();// QQ почтовый ящик: SMTP.QQ.com; 126 почтовый ящик: SMTP.126.com              
            client.Host = "smtp.qq.com";
            client.Port = 587;// SMTP Port 465 или 587
            client.EnableSsl = true;// Соединение с безопасным шифрованием SSL  
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(MyEmailAddress, AuthorizationCode);// проверить идентичность отправителя (почтовый ящик отправителя, код авторизации почтовых ящиков);                   

            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось отправить", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        /// <summary>
        // / Проверить почтовый ящик QQ
        /// </summary>
        /// <param name = "mail"> Email </ param>
        /// <returns></returns>
        public static bool CheckMail(string mail)
        {
            string str = @"^[1-9][0-9]{4,}@qq.com$";
            Regex mReg = new Regex(str);

            if (mReg.IsMatch(mail))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
