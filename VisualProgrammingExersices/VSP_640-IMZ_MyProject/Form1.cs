using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPS_640_IMZ_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttonResults.Enabled = false;
            this.textBox1.Tag = false;
            this.textBox1.Validating += new CancelEventHandler(textBoxEmpty_Validating);

        }
        private void ValidateResult()
        {
            this.buttonResults.Enabled =( (bool)(this.textBox1.Tag));
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.FromArgb(245, 50, 50);
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateResult();

        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            string text = "";
            

            string name = "Резултатите на: "+textBox1.Text+textBoxFamilyName.Text+"\n";

            string type = "";



            if (radioButtonExtrovert.Checked)
            {
                text += "Екстраверсия — E означава Екстраверсия." +
                    " Хората, които имат това личностно предпочитание," +
                    " се зареждат с енергия от външния свят." +
                    " Те обикновено споделят идеите си устно и се „зареждат“ като са сред други хора.\n";
                type += "E";
            }
            else if (radioButtonIntrovert.Checked)
            {
                text += "Интроверсия — I означава интроверсия. Хората с това личностно предпочитание се зареждат от вътрешния си свят." +
                    "Интровертите използват енергията си във взаимодействие с хора и неща, а получават енергия (презареждат се), " +
                    "като прекарват времето си сами и в главите си. Обикновено предпочитат да преминат през всички свои идеи и след това да ги споделят на глас.\n";
                type += "I";
            }

            if (radioButtonSensing.Checked)
            {
                text += "S е за  'Sensing'. Хората, които имат буквата S във  MBTI," +
                    " са склонни да обработват нещата в линейна последователност стъпка по стъпка и да наблюдават и запомнят специфична информация." +
                    " Те също така са склонни да се съсредоточават върху фактите и това, което могат да наблюдават чрез техните пет сетива.\n";
                type += "S";
            }else if (radioButtonIntuition.Checked)
            {
                text += "Интуиция – N е за интуицията (защото вече използвахме буквата I за интровертност) " +
                    " хората, които имат предпочитания към интуицията, обикновено се учат, като виждат голямата картина  и мислят за това как е свързана конкретна информация в нея.\n";
                type += "N";
            }

            if (radioButtonThinking.Checked)
            {
                text += "'Thinking' – буквата Т е за 'мислене'.Хората, които имат това предпочитание," +
                    " са склонни да вземат решения въз основа на плюсове и минуси и претегляйки логическите" +
                    " последствия от обективна гледна точка.\n";
                type += "T";
            }
            else if (radioButtonFeeling.Checked)
            {
                text += "'Feeling' – буквата F - Означава, че човекът взема решения въз основа на това как тези решения могат да повлияят на другите участващи хора.\n";
                type += "F";
            }

            if (radioButtonJuding.Checked)
            {
                text += "Хората, които разчитат на чувството си за преценка," +
                    " обикновено са организирани и рационални мислители," +
                    " които обичат да решават проблемите по линеен и справедлив начин." +
                    " Тези хора също са отговорни и обичат да се придържат към правилата.\n";
                type += "J";
            }
            else if (radioButtonPrecieving.Checked)
            {
                text += "Хората, които разчитат на своето възприятие," +
                    " имат доста спокоен начин да се справят с проблемите." +
                    " Толкова спокойни, те може да имат склонност да не завършват това, което са започнали," +
                    " и да бъдат малко прекалено неорганизирани, за да бъдат продуктивни редовно.\n";
                type += "P";
            }
            type += "\n";


            this.richTextBox1.Text = name+type+text;

            if (type == "INTP\n"|| type=="INTJ\n"||type=="ENTP\n"||type=="ENTJ\n")
            {
                this.BackColor = Color.FromArgb(164, 137, 196);
                this.label1.BackColor = Color.FromArgb(164, 137, 196);
                this.labelHead.BackColor = Color.FromArgb(164, 137, 196);
                this.labelName.BackColor= Color.FromArgb(164, 137, 196);
            }else if (type == "INFJ\n" || type == "INFP\n" || type == "ENFJ\n" || type == "ENFP\n")
            {
                this.BackColor = Color.FromArgb(130, 245, 191);
                this.label1.BackColor = Color.FromArgb(130, 245, 191);
                this.labelHead.BackColor = Color.FromArgb(130, 245, 191);
                this.labelName.BackColor = Color.FromArgb(130, 245, 191);
            }
            else if (type == "ISTJ\n" || type == "ISFJ\n" || type == "ESTJ\n" || type == "ISFJ\n")
            {
                this.BackColor = Color.FromArgb(97, 166, 255);
                this.label1.BackColor = Color.FromArgb(97, 166, 255);
                this.labelHead.BackColor = Color.FromArgb(97, 166, 255);
                this.labelName.BackColor = Color.FromArgb(97, 166, 255);

            }else if(type=="ISTP\n"||type=="ISFP\n"||type == "ESTP\n" || type == "ESFP\n")
            {
                this.BackColor = Color.FromArgb(255, 243, 129);
                this.label1.BackColor = Color.FromArgb(255, 243, 129);
                this.labelHead.BackColor = Color.FromArgb(255, 243, 129);
                this.labelName.BackColor = Color.FromArgb(255, 243, 129);
            }


        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            string helpТext = "Тестът на Майер Брингс.Типологията на Майерс-Бригс е психометричен въпросник," +
                " създаден за измерване на психологическите предпочитания в това как хората възприемат света и взимат решения." +
                " Тези предпочитания са екстраполирани (извадени) от типологически теории," +
                " произхождащи от Карл Густав Юнг и публикувани в неговата книга от 1921 г. Психологически типове." +
                " Първоначалните развиващи този личностен въпросник са Катарин Кук Бригс и дъщеря ѝ Изабел Бригс Майерс." +
                " Те започват да го създават по време на Втората световна война, вярвайки че познанието за" +
                " личностните предпочитания ще помогне на хората да се идентифицират с работата, за която биха били „най-удобни и ефективни“." +
                " Първоначалният въпросник прераства в типология на Майерс-Бригс, публикувана за първи път през 1962 г. " +
                "Типологията се фокусира върху нормални популации и набляга на стойността на естествено появяващи се различия. ";
            this.richTextBox1.Text = helpТext;
            this.BackColor = Color.Beige;
            this.labelName.BackColor = Color.Beige;
            this.labelHead.BackColor = Color.Beige;
            this.label1.BackColor = Color.Beige;
            
        }
    }
}
