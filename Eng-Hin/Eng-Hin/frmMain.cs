using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Eng_Hin
{
    public partial class frmMain : Form
    {

        string engAlphabets = string.Empty;
        bool flagFinal = false;
        bool breakWord = false;
        int upperSymbolCounter = 0;
        long textLength = 0;
        long selectionStartValue = 0;

        string lastCharacter = string.Empty;
        string hindiCharacter = string.Empty;
        string alphabets = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        bool openFlag = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);  
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private string GetHindi(string EngCharacter)
        {
            string HinCharacter = string.Empty;

            //Unicode Translation with consonants

            #region All Consonants Half Alphabet
            if (EngCharacter == "k")
            {
                HinCharacter = "क्";
                selectionStartValue = selectionStartValue + 1;
            }

            if (EngCharacter == "kh")
                HinCharacter = "ख्";

            if (EngCharacter == "g")
                HinCharacter = "ग्";

            if (EngCharacter == "gh")
                HinCharacter = "घ्";

            if (EngCharacter == "ch")
                HinCharacter = "च्";

            if (EngCharacter == "Ch" || EngCharacter == "chh")
                HinCharacter = "छ्";

            if (EngCharacter == "j")
                HinCharacter = "ज";

            if (EngCharacter == "jh")
                HinCharacter = "झ";

            if (EngCharacter == "T")
                HinCharacter = "ट्";

            if (EngCharacter == "Th")
                HinCharacter = "ठ्";

            if (EngCharacter == "D")
                HinCharacter = "ड्";

            if (EngCharacter == "Dh")
                HinCharacter = "ढ्";

            if (EngCharacter == "N")
                HinCharacter = "ण्";

            if (EngCharacter == "t")
                HinCharacter = "त्";

            if (EngCharacter == "th")
                HinCharacter = "थ्";

            if (EngCharacter == "d")
                HinCharacter = "द्";

            if (EngCharacter == "dh")
                HinCharacter = "ध्";

            if (EngCharacter == "n")
                HinCharacter = "न्";

            if (EngCharacter == "p")
                HinCharacter = "प्";

            if (EngCharacter == "ph" || EngCharacter == "f")
                HinCharacter = "फ्";

            if (EngCharacter == "b")
                HinCharacter = "ब्";

            if (EngCharacter == "bh")
                HinCharacter = "भ्";

            if (EngCharacter == "m")
                HinCharacter = "म्";

            if (EngCharacter == "y")
                HinCharacter = "य्";

            if (EngCharacter == "r")
                HinCharacter = "र्";

            if (EngCharacter == "l")
                HinCharacter = "ल्";

            if (EngCharacter == "L")
                HinCharacter = "ळ्";

            if (EngCharacter == "v" || EngCharacter == "w")
                HinCharacter = "व्";

            if (EngCharacter == "sh")
                HinCharacter = "श्";

            if (EngCharacter == "Sh" || EngCharacter == "shh")
                HinCharacter = "ष्";

            if (EngCharacter == "s")
                HinCharacter = "स्";

            if (EngCharacter == "h")
                HinCharacter = "ह्";

            if (EngCharacter == "ksh")
                HinCharacter = "क्ष्";

            #endregion

            #region Consonants ka क
            if (EngCharacter == "ka")
            {
                HinCharacter = "क";
                selectionStartValue = selectionStartValue - 1;
            }

            if (EngCharacter == "kaa")
            {
                HinCharacter = "का";
                flagFinal = true;
            }

            if (EngCharacter == "ki")
                HinCharacter = "कि";

            if (EngCharacter == "kii")
            {
                HinCharacter = "की";
                flagFinal = true;
            }

            if (EngCharacter == "ku")
                HinCharacter = "कु";

            if (EngCharacter == "kuu")
            {
                HinCharacter = "कू";
                flagFinal = true;
            }

            if (EngCharacter == "ke")
            {
                HinCharacter = "के";
                flagFinal = true;
            }

            if (EngCharacter == "kai")
            {
                HinCharacter = "कै";
                flagFinal = true;
            }

            if (EngCharacter == "ko")
            {
                HinCharacter = "को";
                flagFinal = true;
            }

            if (EngCharacter == "kau")
            {
                HinCharacter = "कौ";
                flagFinal = true;
            }

            if (EngCharacter == "kM")
            {
                flagFinal = true;
                HinCharacter = "कं";
            }

            if (EngCharacter == "kH")
            {
                flagFinal = true;
                HinCharacter = "कः";
            }
            #endregion

            #region Consonants kha ख
            if (EngCharacter == "kha")
                HinCharacter = "ख";

            if (EngCharacter == "khaa")
            {
                HinCharacter = "खा";
                flagFinal = true;
            }

            if (EngCharacter == "khi")
                HinCharacter = "खि";

            if (EngCharacter == "khii")
            {
                HinCharacter = "खी";
                flagFinal = true;
            }

            if (EngCharacter == "khu")
                HinCharacter = "खु";

            if (EngCharacter == "khuu")
            {
                HinCharacter = "खू";
                flagFinal = true;
            }

            if (EngCharacter == "khe")
            {
                HinCharacter = "खे";
                flagFinal = true;
            }

            if (EngCharacter == "khai")
            {
                HinCharacter = "खै";
                flagFinal = true;
            }

            if (EngCharacter == "kho")
            {
                HinCharacter = "खो";
                flagFinal = true;
            }

            if (EngCharacter == "khau")
            {
                HinCharacter = "खौ";
                flagFinal = true;
            }

            if (EngCharacter == "khM")
            {
                flagFinal = true;
                HinCharacter = "खं";
            }
            #endregion

            #region Consonants ga ग
            if (EngCharacter == "ga")
                HinCharacter = "ग";

            if (EngCharacter == "gaa")
            {
                HinCharacter = "गा";
                flagFinal = true;
            }

            if (EngCharacter == "gi")
                HinCharacter = "गि";

            if (EngCharacter == "gii")
            {
                HinCharacter = "गी";
                flagFinal = true;
            }

            if (EngCharacter == "gu")
                HinCharacter = "गु";

            if (EngCharacter == "guu")
            {
                HinCharacter = "गू";
                flagFinal = true;
            }

            if (EngCharacter == "ge")
            {
                HinCharacter = "गे";
                flagFinal = true;
            }

            if (EngCharacter == "gai")
            {
                HinCharacter = "गौ";
                flagFinal = true;
            }

            if (EngCharacter == "go")
            {
                HinCharacter = "गो";
                flagFinal = true;
            }

            if (EngCharacter == "gau")
            {
                HinCharacter = "गौ";
                flagFinal = true;
            }

            if (EngCharacter == "gM")
            {
                flagFinal = true;
                HinCharacter = "गं";
            }
            #endregion

            #region Consonants gha घ
            if (EngCharacter == "gha")
                HinCharacter = "घ";

            if (EngCharacter == "ghaa")
            {
                HinCharacter = "घा";
                flagFinal = true;
            }

            if (EngCharacter == "ghi")
                HinCharacter = "घि";

            if (EngCharacter == "ghii")
            {
                HinCharacter = "घी";
                flagFinal = true;
            }

            if (EngCharacter == "ghu")
                HinCharacter = "घु";

            if (EngCharacter == "ghuu")
            {
                HinCharacter = "घू";
                flagFinal = true;
            }

            if (EngCharacter == "ghe")
            {
                HinCharacter = "घे";
                flagFinal = true;
            }

            if (EngCharacter == "ghai")
            {
                HinCharacter = "घै";
                flagFinal = true;
            }

            if (EngCharacter == "gho")
            {
                HinCharacter = "घो";
                flagFinal = true;
            }

            if (EngCharacter == "ghau")
            {
                HinCharacter = "घौ";
                flagFinal = true;
            }

            if (EngCharacter == "ghM")
            {
                flagFinal = true;
                HinCharacter = "घं";
            }
            #endregion

            #region Consonants ch च
            if (EngCharacter == "cha")
                HinCharacter = "च";

            if (EngCharacter == "chaa")
            {
                HinCharacter = "चा";
                flagFinal = true;
            }

            if (EngCharacter == "chi")
                HinCharacter = "चि";

            if (EngCharacter == "chii")
            {
                HinCharacter = "ची";
                flagFinal = true;
            }

            if (EngCharacter == "chu")
                HinCharacter = "चु";

            if (EngCharacter == "chuu")
            {
                HinCharacter = "चू";
                flagFinal = true;
            }

            if (EngCharacter == "che")
            {
                HinCharacter = "चे";
                flagFinal = true;
            }

            if (EngCharacter == "chai")
            {
                HinCharacter = "चै";
                flagFinal = true;
            }

            if (EngCharacter == "cho")
            {
                HinCharacter = "चो";
                flagFinal = true;
            }

            if (EngCharacter == "chau")
            {
                HinCharacter = "चौ";
                flagFinal = true;
            }

            if (EngCharacter == "chM")
            {
                flagFinal = true;
                HinCharacter = "चं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants chh छ
            if (EngCharacter == "chha")
                HinCharacter = "छ";

            if (EngCharacter == "chhaa")
            {
                HinCharacter = "छा";
                flagFinal = true;
            }

            if (EngCharacter == "chhi")
                HinCharacter = "छि";

            if (EngCharacter == "chhii")
            {
                HinCharacter = "छी";
                flagFinal = true;
            }

            if (EngCharacter == "chhu")
                HinCharacter = "छु";

            if (EngCharacter == "chhuu")
            {
                HinCharacter = "छू";
                flagFinal = true;
            }

            if (EngCharacter == "chhe")
            {
                HinCharacter = "छे";
                flagFinal = true;
            }

            if (EngCharacter == "chhai")
            {
                HinCharacter = "छै";
                flagFinal = true;
            }

            if (EngCharacter == "chho")
            {
                HinCharacter = "छो";
                flagFinal = true;
            }

            if (EngCharacter == "chhau")
            {
                HinCharacter = "छौ";
                flagFinal = true;
            }

            if (EngCharacter == "chhM")
            {
                flagFinal = true;
                HinCharacter = "छँ";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants ja ज
            if (EngCharacter == "ja")
                HinCharacter = "ज";

            if (EngCharacter == "jaa")
            {
                HinCharacter = "जा";
                flagFinal = true;
            }

            if (EngCharacter == "ji")
                HinCharacter = "जि";

            if (EngCharacter == "jii")
            {
                HinCharacter = "जी";
                flagFinal = true;
            }

            if (EngCharacter == "ju")
                HinCharacter = "जु";

            if (EngCharacter == "juu")
            {
                HinCharacter = "जू";
                flagFinal = true;
            }

            if (EngCharacter == "je")
            {
                HinCharacter = "जे";
                flagFinal = true;
            }

            if (EngCharacter == "jai")
            {
                HinCharacter = "जै";
                flagFinal = true;
            }

            if (EngCharacter == "jo")
            {
                HinCharacter = "जो";
                flagFinal = true;
            }

            if (EngCharacter == "jau")
            {
                HinCharacter = "जौ";
                flagFinal = true;
            }

            if (EngCharacter == "jM")
            {
                flagFinal = true;
                HinCharacter = "जं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants jha झ
            if (EngCharacter == "jha")
                HinCharacter = "झ";

            if (EngCharacter == "jhaa")
            {
                HinCharacter = "झा";
                flagFinal = true;
            }

            if (EngCharacter == "jhi")
                HinCharacter = "झि";

            if (EngCharacter == "jhii")
            {
                HinCharacter = "झी";
                flagFinal = true;
            }

            if (EngCharacter == "jhu")
                HinCharacter = "झु";

            if (EngCharacter == "jhuu")
            {
                HinCharacter = "झू";
                flagFinal = true;
            }

            if (EngCharacter == "jhe")
            {
                HinCharacter = "झे";
                flagFinal = true;
            }

            if (EngCharacter == "jhai")
            {
                HinCharacter = "झै";
                flagFinal = true;
            }

            if (EngCharacter == "jho")
            {
                HinCharacter = "झो";
                flagFinal = true;
            }

            if (EngCharacter == "jhau")
            {
                HinCharacter = "झौ";
                flagFinal = true;
            }

            if (EngCharacter == "jhM")
            {
                flagFinal = true;
                HinCharacter = "झं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants ta ट
            if (EngCharacter == "Ta")
                HinCharacter = "ट";

            if (EngCharacter == "Taa")
            {
                HinCharacter = "टा";
                flagFinal = true;
            }

            if (EngCharacter == "Ti")
                HinCharacter = "टि";

            if (EngCharacter == "Tii")
            {
                HinCharacter = "टी";
                flagFinal = true;
            }

            if (EngCharacter == "Tu")
                HinCharacter = "टु";

            if (EngCharacter == "Tuu")
            {
                HinCharacter = "टू";
                flagFinal = true;
            }

            if (EngCharacter == "Te")
            {
                HinCharacter = "टे";
                flagFinal = true;
            }

            if (EngCharacter == "Tai")
            {
                HinCharacter = "टै";
                flagFinal = true;
            }

            if (EngCharacter == "To")
            {
                HinCharacter = "टो";
                flagFinal = true;
            }

            if (EngCharacter == "Tau")
            {
                HinCharacter = "टौ";
                flagFinal = true;
            }

            if (EngCharacter == "TM")
            {
                flagFinal = true;
                HinCharacter = "टं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants Tha ठ
            if (EngCharacter == "Tha")
                HinCharacter = "ठ";

            if (EngCharacter == "Thaa")
            {
                HinCharacter = "ठा";
                flagFinal = true;
            }

            if (EngCharacter == "Thi")
                HinCharacter = "ठि";

            if (EngCharacter == "Thii")
            {
                HinCharacter = "ठी";
                flagFinal = true;
            }

            if (EngCharacter == "Thu")
                HinCharacter = "ठु";

            if (EngCharacter == "Thuu")
            {
                HinCharacter = "ठू";
                flagFinal = true;
            }

            if (EngCharacter == "The")
            {
                HinCharacter = "ठे";
                flagFinal = true;
            }

            if (EngCharacter == "Thai")
            {
                HinCharacter = "ठै";
                flagFinal = true;
            }

            if (EngCharacter == "Tho")
            {
                HinCharacter = "ठो";
                flagFinal = true;
            }

            if (EngCharacter == "Thau")
            {
                HinCharacter = "ठौ";
                flagFinal = true;
            }

            if (EngCharacter == "ThM")
            {
                flagFinal = true;
                HinCharacter = "ठं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants Da ङ
            if (EngCharacter == "Da")
                HinCharacter = "ङ";

            if (EngCharacter == "Daa")
            {
                HinCharacter = "ङा";
                flagFinal = true;
            }

            if (EngCharacter == "Di")
                HinCharacter = "ङि";

            if (EngCharacter == "Dii")
            {
                HinCharacter = "ङी";
                flagFinal = true;
            }

            if (EngCharacter == "Du")
                HinCharacter = "ङु";

            if (EngCharacter == "Duu")
            {
                HinCharacter = "ङू";
                flagFinal = true;
            }

            if (EngCharacter == "De")
            {
                HinCharacter = "ङे";
                flagFinal = true;
            }

            if (EngCharacter == "Dai")
            {
                HinCharacter = "ङै";
                flagFinal = true;
            }

            if (EngCharacter == "Do")
            {
                HinCharacter = "ङो";
                flagFinal = true;
            }

            if (EngCharacter == "Dau")
            {
                HinCharacter = "ङौ";
                flagFinal = true;
            }

            if (EngCharacter == "DM")
            {
                flagFinal = true;
                HinCharacter = "ङं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants Dha ढ
            if (EngCharacter == "Dha")
                HinCharacter = "ढ";

            if (EngCharacter == "Dhaa")
            {
                HinCharacter = "ढा";
                flagFinal = true;
            }

            if (EngCharacter == "Dhi")
                HinCharacter = "ढि";

            if (EngCharacter == "Dhii")
            {
                HinCharacter = "ढी";
                flagFinal = true;
            }

            if (EngCharacter == "Dhu")
                HinCharacter = "ढु";

            if (EngCharacter == "Dhuu")
            {
                HinCharacter = "ढू";
                flagFinal = true;
            }

            if (EngCharacter == "Dhe")
            {
                HinCharacter = "ढे";
                flagFinal = true;
            }

            if (EngCharacter == "Dhai")
            {
                HinCharacter = "ढै";
                flagFinal = true;
            }

            if (EngCharacter == "Dho")
            {
                HinCharacter = "ढो";
                flagFinal = true;
            }

            if (EngCharacter == "Dhau")
            {
                HinCharacter = "ढौ";
                flagFinal = true;
            }

            if (EngCharacter == "DhM")
            {
                flagFinal = true;
                HinCharacter = "ढं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants Na ण
            if (EngCharacter == "Na")
                HinCharacter = "ण";

            if (EngCharacter == "Naa")
            {
                HinCharacter = "णा";
                flagFinal = true;
            }

            if (EngCharacter == "Ni")
                HinCharacter = "णि";

            if (EngCharacter == "Nii")
            {
                HinCharacter = "णी";
                flagFinal = true;
            }

            if (EngCharacter == "Nu")
                HinCharacter = "णु";

            if (EngCharacter == "Nuu")
            {
                HinCharacter = "णू";
                flagFinal = true;
            }

            if (EngCharacter == "Ne")
            {
                HinCharacter = "णे";
                flagFinal = true;
            }

            if (EngCharacter == "Nai")
            {
                HinCharacter = "णै";
                flagFinal = true;
            }

            if (EngCharacter == "No")
            {
                HinCharacter = "णो";
                flagFinal = true;
            }

            if (EngCharacter == "Nau")
            {
                HinCharacter = "णौ";
                flagFinal = true;
            }

            if (EngCharacter == "NM")
            {
                flagFinal = true;
                HinCharacter = "णं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants t त
            if (EngCharacter == "ta")
                HinCharacter = "त";

            if (EngCharacter == "taa")
            {
                HinCharacter = "ता";
                flagFinal = true;
            }

            if (EngCharacter == "ti")
                HinCharacter = "ति";

            if (EngCharacter == "tii")
            {
                HinCharacter = "ती";
                flagFinal = true;
            }

            if (EngCharacter == "tu")
                HinCharacter = "तु";

            if (EngCharacter == "tuu")
            {
                HinCharacter = "तू";
                flagFinal = true;
            }

            if (EngCharacter == "te")
            {
                HinCharacter = "ते";
                flagFinal = true;
            }

            if (EngCharacter == "tai")
            {
                HinCharacter = "तै";
                flagFinal = true;
            }

            if (EngCharacter == "to")
            {
                HinCharacter = "तो";
                flagFinal = true;
            }

            if (EngCharacter == "tau")
            {
                HinCharacter = "तौ";
                flagFinal = true;
            }

            if (EngCharacter == "tM")
            {
                flagFinal = true;
                HinCharacter = "तं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants th थ
            if (EngCharacter == "tha")
                HinCharacter = "थ";

            if (EngCharacter == "thaa")
            {
                HinCharacter = "था";
                flagFinal = true;
            }

            if (EngCharacter == "thi")
                HinCharacter = "थि";

            if (EngCharacter == "thii")
            {
                HinCharacter = "थी";
                flagFinal = true;
            }

            if (EngCharacter == "thu")
                HinCharacter = "थु";

            if (EngCharacter == "thuu")
            {
                HinCharacter = "थू";
                flagFinal = true;
            }

            if (EngCharacter == "the")
            {
                HinCharacter = "थे";
                flagFinal = true;
            }

            if (EngCharacter == "thai")
            {
                HinCharacter = "थै";
                flagFinal = true;
            }

            if (EngCharacter == "tho")
            {
                HinCharacter = "थो";
                flagFinal = true;
            }

            if (EngCharacter == "thau")
            {
                HinCharacter = "थौ";
                flagFinal = true;
            }

            if (EngCharacter == "thM")
            {
                flagFinal = true;
                HinCharacter = "थं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants d द
            if (EngCharacter == "da")
                HinCharacter = "द";

            if (EngCharacter == "daa")
            {
                HinCharacter = "दा";
                flagFinal = true;
            }

            if (EngCharacter == "di")
                HinCharacter = "दि";

            if (EngCharacter == "dii")
            {
                HinCharacter = "दी";
                flagFinal = true;
            }

            if (EngCharacter == "du")
                HinCharacter = "दु";

            if (EngCharacter == "duu")
            {
                HinCharacter = "दू";
                flagFinal = true;
            }

            if (EngCharacter == "de")
            {
                HinCharacter = "दे";
                flagFinal = true;
            }

            if (EngCharacter == "dai")
            {
                HinCharacter = "दै";
                flagFinal = true;
            }

            if (EngCharacter == "do")
            {
                HinCharacter = "दो";
                flagFinal = true;
            }

            if (EngCharacter == "dau")
            {
                HinCharacter = "दौ";
                flagFinal = true;
            }

            if (EngCharacter == "dM")
            {
                flagFinal = true;
                HinCharacter = "दं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants dh ध
            if (EngCharacter == "dha")
                HinCharacter = "ध";

            if (EngCharacter == "dhaa")
            {
                HinCharacter = "धा";
                flagFinal = true;
            }

            if (EngCharacter == "dhi")
                HinCharacter = "धि";

            if (EngCharacter == "dhii")
            {
                HinCharacter = "धी";
                flagFinal = true;
            }

            if (EngCharacter == "dhu")
                HinCharacter = "धु";

            if (EngCharacter == "dhuu")
            {
                HinCharacter = "धू";
                flagFinal = true;
            }

            if (EngCharacter == "dhe")
            {
                HinCharacter = "धे";
                flagFinal = true;
            }

            if (EngCharacter == "dhai")
            {
                HinCharacter = "धै";
                flagFinal = true;
            }

            if (EngCharacter == "dho")
            {
                HinCharacter = "धो";
                flagFinal = true;
            }

            if (EngCharacter == "dhau")
            {
                HinCharacter = "धौ";
                flagFinal = true;
            }

            if (EngCharacter == "dhM")
            {
                flagFinal = true;
                HinCharacter = "धं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants n न
            if (EngCharacter == "na")
            {
                HinCharacter = "न";
                selectionStartValue = selectionStartValue - 1;
            }

            if (EngCharacter == "naa")
            {
                HinCharacter = "ना";
                flagFinal = true;
            }

            if (EngCharacter == "ni")
                HinCharacter = "नि";

            if (EngCharacter == "nii")
            {
                HinCharacter = "नी";
                flagFinal = true;
            }

            if (EngCharacter == "nu")
                HinCharacter = "नु";

            if (EngCharacter == "nuu")
            {
                HinCharacter = "नू";
                flagFinal = true;
            }

            if (EngCharacter == "ne")
            {
                HinCharacter = "ने";
                flagFinal = true;
            }

            if (EngCharacter == "nai")
            {
                HinCharacter = "नै";
                flagFinal = true;
            }

            if (EngCharacter == "no")
            {
                HinCharacter = "नो";
                flagFinal = true;
            }

            if (EngCharacter == "nau")
            {
                HinCharacter = "नौ";
                flagFinal = true;
            }

            if (EngCharacter == "nM")
            {
                flagFinal = true;
                HinCharacter = "नं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants p प
            if (EngCharacter == "pa")
                HinCharacter = "प";

            if (EngCharacter == "paa")
            {
                HinCharacter = "पा";
                flagFinal = true;
            }

            if (EngCharacter == "pi")
                HinCharacter = "पि";

            if (EngCharacter == "pii")
            {
                HinCharacter = "पी";
                flagFinal = true;
            }

            if (EngCharacter == "pu")
                HinCharacter = "पु";

            if (EngCharacter == "puu")
            {
                HinCharacter = "पू";
                flagFinal = true;
            }

            if (EngCharacter == "pe")
            {
                HinCharacter = "पे";
                flagFinal = true;
            }

            if (EngCharacter == "pai")
            {
                HinCharacter = "पै";
                flagFinal = true;
            }

            if (EngCharacter == "po")
            {
                HinCharacter = "पो";
                flagFinal = true;
            }

            if (EngCharacter == "pau")
            {
                HinCharacter = "पौ";
                flagFinal = true;
            }

            if (EngCharacter == "pM")
            {
                flagFinal = true;
                HinCharacter = "पं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants ph f प
            if (EngCharacter == "pha" || EngCharacter == "fa")
                HinCharacter = "फ";

            if (EngCharacter == "phaa" || EngCharacter == "faa")
            {
                HinCharacter = "फा";
                flagFinal = true;
            }

            if (EngCharacter == "phi" || EngCharacter == "fi")
                HinCharacter = "फि";

            if (EngCharacter == "phii" || EngCharacter == "fii")
            {
                HinCharacter = "फी";
                flagFinal = true;
            }

            if (EngCharacter == "phu" || EngCharacter == "fu")
                HinCharacter = "फु";

            if (EngCharacter == "phuu" || EngCharacter == "fuu")
            {
                HinCharacter = "फू";
                flagFinal = true;
            }

            if (EngCharacter == "phe" || EngCharacter == "fe")
            {
                HinCharacter = "फे";
                flagFinal = true;
            }

            if (EngCharacter == "phai" || EngCharacter == "fai")
            {
                HinCharacter = "फै";
                flagFinal = true;
            }

            if (EngCharacter == "pho" || EngCharacter == "fo")
            {
                HinCharacter = "फो";
                flagFinal = true;
            }

            if (EngCharacter == "phau" || EngCharacter == "fau")
            {
                HinCharacter = "फौ";
                flagFinal = true;
            }

            if (EngCharacter == "phM" || EngCharacter == "fM")
            {
                flagFinal = true;
                HinCharacter = "फं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants b प
            if (EngCharacter == "ba")
                HinCharacter = "ब";

            if (EngCharacter == "baa")
            {
                HinCharacter = "बा";
                flagFinal = true;
            }

            if (EngCharacter == "bi")
                HinCharacter = "बि";

            if (EngCharacter == "bii")
            {
                HinCharacter = "बी";
                flagFinal = true;
            }

            if (EngCharacter == "bu")
                HinCharacter = "बु";

            if (EngCharacter == "buu")
            {
                HinCharacter = "बू";
                flagFinal = true;
            }

            if (EngCharacter == "be")
            {
                HinCharacter = "बे";
                flagFinal = true;
            }

            if (EngCharacter == "bai")
            {
                HinCharacter = "बै";
                flagFinal = true;
            }

            if (EngCharacter == "bo")
            {
                HinCharacter = "बो";
                flagFinal = true;
            }

            if (EngCharacter == "bau")
            {
                HinCharacter = "बौ";
                flagFinal = true;
            }

            if (EngCharacter == "bM")
            {
                flagFinal = true;
                HinCharacter = "बं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants bh भ
            if (EngCharacter == "bha")
                HinCharacter = "भ";

            if (EngCharacter == "bhaa")
            {
                HinCharacter = "भा";
                flagFinal = true;
            }

            if (EngCharacter == "bhi")
                HinCharacter = "भि";

            if (EngCharacter == "bhii")
            {
                HinCharacter = "भी";
                flagFinal = true;
            }

            if (EngCharacter == "bhu")
                HinCharacter = "भु";

            if (EngCharacter == "bhuu")
            {
                HinCharacter = "भू";
                flagFinal = true;
            }

            if (EngCharacter == "bhe")
            {
                HinCharacter = "भे";
                flagFinal = true;
            }

            if (EngCharacter == "bhai")
            {
                HinCharacter = "भै";
                flagFinal = true;
            }

            if (EngCharacter == "bho")
            {
                HinCharacter = "भो";
                flagFinal = true;
            }

            if (EngCharacter == "bhau")
            {
                HinCharacter = "भौ";
                flagFinal = true;
            }

            if (EngCharacter == "bhM")
            {
                flagFinal = true;
                HinCharacter = "भं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants m म
            if (EngCharacter == "ma")
            {
                HinCharacter = "म";
                selectionStartValue = selectionStartValue - 1;
            }

            if (EngCharacter == "maa")
            {
                HinCharacter = "मा";
                flagFinal = true;
            }

            if (EngCharacter == "mi")
                HinCharacter = "मि";

            if (EngCharacter == "mii")
            {
                HinCharacter = "मी";
                flagFinal = true;
            }

            if (EngCharacter == "mu")
                HinCharacter = "मु";

            if (EngCharacter == "muu")
            {
                HinCharacter = "मू";
                flagFinal = true;
            }

            if (EngCharacter == "me")
            {
                HinCharacter = "मे";
                flagFinal = true;
            }

            if (EngCharacter == "mai")
            {
                HinCharacter = "मै";
                flagFinal = true;
            }

            if (EngCharacter == "mo")
            {
                HinCharacter = "मो";
                flagFinal = true;
            }

            if (EngCharacter == "mau")
            {
                HinCharacter = "मौ";
                flagFinal = true;
            }

            if (EngCharacter == "mM")
            {
                flagFinal = true;
                HinCharacter = "मं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants y य
            if (EngCharacter == "ya")
                HinCharacter = "य";

            if (EngCharacter == "yaa")
            {
                HinCharacter = "या";
                flagFinal = true;
            }

            if (EngCharacter == "yi")
                HinCharacter = "यि";

            if (EngCharacter == "yii")
            {
                HinCharacter = "यी";
                flagFinal = true;
            }

            if (EngCharacter == "yu")
                HinCharacter = "यु";

            if (EngCharacter == "yuu")
            {
                HinCharacter = "यू";
                flagFinal = true;
            }

            if (EngCharacter == "ye")
            {
                HinCharacter = "ये";
                flagFinal = true;
            }

            if (EngCharacter == "yai")
            {
                HinCharacter = "यै";
                flagFinal = true;
            }

            if (EngCharacter == "yo")
            {
                HinCharacter = "यो";
                flagFinal = true;
            }

            if (EngCharacter == "yau")
            {
                HinCharacter = "यौ";
                flagFinal = true;
            }

            if (EngCharacter == "yM")
            {
                flagFinal = true;
                HinCharacter = "यं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants r र
            if (EngCharacter == "ra")
                HinCharacter = "र";

            if (EngCharacter == "raa")
            {
                HinCharacter = "रा";
                flagFinal = true;
            }

            if (EngCharacter == "ri")
                HinCharacter = "रि";

            if (EngCharacter == "rii")
            {
                HinCharacter = "री";
                flagFinal = true;
            }

            if (EngCharacter == "ru")
                HinCharacter = "रु";

            if (EngCharacter == "ruu")
            {
                HinCharacter = "रू";
                flagFinal = true;
            }

            if (EngCharacter == "re")
            {
                HinCharacter = "रे";
                flagFinal = true;
            }

            if (EngCharacter == "rai")
            {
                HinCharacter = "रै";
                flagFinal = true;
            }

            if (EngCharacter == "ro")
            {
                HinCharacter = "रो";
                flagFinal = true;
            }

            if (EngCharacter == "rau")
            {
                HinCharacter = "रौ";
                flagFinal = true;
            }

            if (EngCharacter == "rM")
            {
                flagFinal = true;
                HinCharacter = "रं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants r र
            if (EngCharacter == "ra")
                HinCharacter = "र";

            if (EngCharacter == "raa")
            {
                HinCharacter = "रा";
                flagFinal = true;
            }

            if (EngCharacter == "ri")
                HinCharacter = "रि";

            if (EngCharacter == "rii")
            {
                HinCharacter = "री";
                flagFinal = true;
            }

            if (EngCharacter == "ru")
                HinCharacter = "रु";

            if (EngCharacter == "ruu")
            {
                HinCharacter = "रू";
                flagFinal = true;
            }

            if (EngCharacter == "re")
            {
                HinCharacter = "रे";
                flagFinal = true;
            }

            if (EngCharacter == "rai")
            {
                HinCharacter = "रै";
                flagFinal = true;
            }

            if (EngCharacter == "ro")
            {
                HinCharacter = "रो";
                flagFinal = true;
            }

            if (EngCharacter == "rau")
            {
                HinCharacter = "रौ";
                flagFinal = true;
            }

            if (EngCharacter == "rM")
            {
                flagFinal = true;
                HinCharacter = "रं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants l ल
            if (EngCharacter == "la")
                HinCharacter = "ल";

            if (EngCharacter == "laa")
            {
                HinCharacter = "ला";
                flagFinal = true;
            }

            if (EngCharacter == "li")
                HinCharacter = "लि";

            if (EngCharacter == "lii")
            {
                HinCharacter = "ली";
                flagFinal = true;
            }

            if (EngCharacter == "lu")
                HinCharacter = "लु";

            if (EngCharacter == "luu")
            {
                HinCharacter = "लू";
                flagFinal = true;
            }

            if (EngCharacter == "le")
            {
                HinCharacter = "ले";
                flagFinal = true;
            }

            if (EngCharacter == "lai")
            {
                HinCharacter = "लै";
                flagFinal = true;
            }

            if (EngCharacter == "lo")
            {
                HinCharacter = "लो";
                flagFinal = true;
            }

            if (EngCharacter == "lau")
            {
                HinCharacter = "लौ";
                flagFinal = true;
            }

            if (EngCharacter == "lM")
            {
                flagFinal = true;
                HinCharacter = "लं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants L ळ
            if (EngCharacter == "La")
                HinCharacter = "ळ";

            if (EngCharacter == "Laa")
            {
                HinCharacter = "ळा";
                flagFinal = true;
            }

            if (EngCharacter == "Li")
                HinCharacter = "ळि";

            if (EngCharacter == "Lii")
            {
                HinCharacter = "ळी";
                flagFinal = true;
            }

            if (EngCharacter == "Lu")
                HinCharacter = "ळु";

            if (EngCharacter == "Luu")
            {
                HinCharacter = "ळू";
                flagFinal = true;
            }

            if (EngCharacter == "Le")
            {
                HinCharacter = "ळे";
                flagFinal = true;
            }

            if (EngCharacter == "Lai")
            {
                HinCharacter = "ळै";
                flagFinal = true;
            }

            if (EngCharacter == "Lo")
            {
                HinCharacter = "ळो";
                flagFinal = true;
            }

            if (EngCharacter == "Lau")
            {
                HinCharacter = "ळौ";
                flagFinal = true;
            }

            if (EngCharacter == "LM")
            {
                flagFinal = true;
                HinCharacter = "ळं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants v w व
            if (EngCharacter == "va" || EngCharacter == "wa")
                HinCharacter = "व";

            if (EngCharacter == "vaa" || EngCharacter == "waa")
            {
                HinCharacter = "वा";
                flagFinal = true;
            }

            if (EngCharacter == "vi" || EngCharacter == "wi")
                HinCharacter = "वि";

            if (EngCharacter == "vii" || EngCharacter == "wii")
            {
                HinCharacter = "वी";
                flagFinal = true;
            }

            if (EngCharacter == "vu" || EngCharacter == "wu")
                HinCharacter = "वु";

            if (EngCharacter == "vuu" || EngCharacter == "wuu")
            {
                HinCharacter = "वू";
                flagFinal = true;
            }

            if (EngCharacter == "ve" || EngCharacter == "we")
            {
                HinCharacter = "वे";
                flagFinal = true;
            }

            if (EngCharacter == "vai" || EngCharacter == "wai")
            {
                HinCharacter = "वै";
                flagFinal = true;
            }

            if (EngCharacter == "vo" || EngCharacter == "wo")
            {
                HinCharacter = "वो";
                flagFinal = true;
            }

            if (EngCharacter == "vau" || EngCharacter == "wau")
            {
                HinCharacter = "वौ";
                flagFinal = true;
            }

            if (EngCharacter == "vM" || EngCharacter == "wM")
            {
                flagFinal = true;
                HinCharacter = "वं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants sh श
            if (EngCharacter == "sha")
                HinCharacter = "श";

            if (EngCharacter == "shaa")
            {
                HinCharacter = "शा";
                flagFinal = true;
            }

            if (EngCharacter == "shi")
                HinCharacter = "शि";

            if (EngCharacter == "shii")
            {
                HinCharacter = "शी";
                flagFinal = true;
            }

            if (EngCharacter == "shu")
                HinCharacter = "शु";

            if (EngCharacter == "shuu")
            {
                HinCharacter = "शू";
                flagFinal = true;
            }

            if (EngCharacter == "she")
            {
                HinCharacter = "शे";
                flagFinal = true;
            }

            if (EngCharacter == "shai")
            {
                HinCharacter = "शै";
                flagFinal = true;
            }

            if (EngCharacter == "sho")
            {
                HinCharacter = "शो";
                flagFinal = true;
            }

            if (EngCharacter == "shau")
            {
                HinCharacter = "शौ";
                flagFinal = true;
            }

            if (EngCharacter == "shM")
            {
                flagFinal = true;
                HinCharacter = "शं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants Sh ष
            if (EngCharacter == "Sha" || EngCharacter == "shha")
                HinCharacter = "ष";

            if (EngCharacter == "Shaa" || EngCharacter == "shhaa")
            {
                HinCharacter = "षा";
                flagFinal = true;
            }

            if (EngCharacter == "Shi" || EngCharacter == "shhi")
                HinCharacter = "षि";

            if (EngCharacter == "Shii" || EngCharacter == "shhii")
            {
                HinCharacter = "षी";
                flagFinal = true;
            }

            if (EngCharacter == "Shu" || EngCharacter == "shhu")
                HinCharacter = "षु";

            if (EngCharacter == "Shuu" || EngCharacter == "shhuu")
            {
                HinCharacter = "षू";
                flagFinal = true;
            }

            if (EngCharacter == "She" || EngCharacter == "shhe")
            {
                HinCharacter = "षे";
                flagFinal = true;
            }

            if (EngCharacter == "Shai" || EngCharacter == "shhai")
            {
                HinCharacter = "षै";
                flagFinal = true;
            }

            if (EngCharacter == "Sho" || EngCharacter == "shho")
            {
                HinCharacter = "षो";
                flagFinal = true;
            }

            if (EngCharacter == "Shau" || EngCharacter == "shhau")
            {
                HinCharacter = "षौ";
                flagFinal = true;
            }

            if (EngCharacter == "ShM" || EngCharacter == "shhM")
            {
                flagFinal = true;
                HinCharacter = "षं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants s स
            if (EngCharacter == "sa")
                HinCharacter = "स";

            if (EngCharacter == "saa")
            {
                HinCharacter = "सा";
                flagFinal = true;
            }

            if (EngCharacter == "si")
                HinCharacter = "सि";

            if (EngCharacter == "sii")
            {
                HinCharacter = "सी";
                flagFinal = true;
            }

            if (EngCharacter == "su")
                HinCharacter = "सु";

            if (EngCharacter == "suu")
            {
                HinCharacter = "सू";
                flagFinal = true;
            }

            if (EngCharacter == "se")
            {
                HinCharacter = "से";
                flagFinal = true;
            }

            if (EngCharacter == "sai")
            {
                HinCharacter = "सै";
                flagFinal = true;
            }

            if (EngCharacter == "so")
            {
                HinCharacter = "सो";
                flagFinal = true;
            }

            if (EngCharacter == "sau")
            {
                HinCharacter = "सौ";
                flagFinal = true;
            }

            if (EngCharacter == "sM")
            {
                flagFinal = true;
                HinCharacter = "सं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants s स
            if (EngCharacter == "sa")
                HinCharacter = "स";

            if (EngCharacter == "saa")
            {
                HinCharacter = "सा";
                flagFinal = true;
            }

            if (EngCharacter == "si")
                HinCharacter = "सि";

            if (EngCharacter == "sii")
            {
                HinCharacter = "सी";
                flagFinal = true;
            }

            if (EngCharacter == "su")
                HinCharacter = "सु";

            if (EngCharacter == "suu")
            {
                HinCharacter = "सू";
                flagFinal = true;
            }

            if (EngCharacter == "se")
            {
                HinCharacter = "से";
                flagFinal = true;
            }

            if (EngCharacter == "sai")
            {
                HinCharacter = "सै";
                flagFinal = true;
            }

            if (EngCharacter == "so")
            {
                HinCharacter = "सो";
                flagFinal = true;
            }

            if (EngCharacter == "sau")
            {
                HinCharacter = "सौ";
                flagFinal = true;
            }

            if (EngCharacter == "sM")
            {
                flagFinal = true;
                HinCharacter = "सं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants h ह
            if (EngCharacter == "ha")
                HinCharacter = "ह";

            if (EngCharacter == "haa")
            {
                HinCharacter = "हा";
                flagFinal = true;
            }

            if (EngCharacter == "hi")
                HinCharacter = "हि";

            if (EngCharacter == "hii")
            {
                HinCharacter = "ही";
                flagFinal = true;
            }

            if (EngCharacter == "hu")
                HinCharacter = "हु";

            if (EngCharacter == "huu")
            {
                HinCharacter = "हू";
                flagFinal = true;
            }

            if (EngCharacter == "he")
            {
                HinCharacter = "हे";
                flagFinal = true;
            }

            if (EngCharacter == "hai")
            {
                HinCharacter = "है";
                flagFinal = true;
            }

            if (EngCharacter == "ho")
            {
                HinCharacter = "हो";
                flagFinal = true;
            }

            if (EngCharacter == "hau")
            {
                HinCharacter = "हौ";
                flagFinal = true;
            }

            if (EngCharacter == "hM")
            {
                flagFinal = true;
                HinCharacter = "हं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Consonants ksh क्ष
            if (EngCharacter == "ksha")
                HinCharacter = "क्ष";

            if (EngCharacter == "kshaa")
            {
                HinCharacter = "क्षा";
                flagFinal = true;
            }

            if (EngCharacter == "kshi")
                HinCharacter = "क्षि";

            if (EngCharacter == "kshii")
            {
                HinCharacter = "क्षी";
                flagFinal = true;
            }

            if (EngCharacter == "kshu")
                HinCharacter = "क्षु";

            if (EngCharacter == "kshuu")
            {
                HinCharacter = "क्षू";
                flagFinal = true;
            }

            if (EngCharacter == "kshe")
            {
                HinCharacter = "क्षे";
                flagFinal = true;
            }

            if (EngCharacter == "kshai")
            {
                HinCharacter = "क्षै";
                flagFinal = true;
            }

            if (EngCharacter == "ksho")
            {
                HinCharacter = "क्षो";
                flagFinal = true;
            }

            if (EngCharacter == "kshau")
            {
                HinCharacter = "क्षौ";
                flagFinal = true;
            }

            if (EngCharacter == "kshM")
            {
                flagFinal = true;
                HinCharacter = "क्षं";
            }

            //if (EngCharacter == "chH")
            //{
            //    flagFinal = true;
            //    HinCharacter = "कः";
            //}
            #endregion

            #region Vowels
            if (EngCharacter == "a")
            {
                HinCharacter = "अ";
                //flagFinal = true;
            }

            if (EngCharacter == "aa" || EngCharacter == "A")
            {
                HinCharacter = "आ";
                flagFinal = true;
            }

            if (EngCharacter == "i")
            {
                HinCharacter = "इ";
                flagFinal = true;
            }

            if (EngCharacter == "ii" || EngCharacter == "I" || EngCharacter == "ee")
            {
                HinCharacter = "ई";
                flagFinal = true;
            }

            if (EngCharacter == "u")
            {
                HinCharacter = "उ";
                flagFinal = true;
            }

            if (EngCharacter == "uu" || EngCharacter == "U" || EngCharacter == "oo")
            {
                HinCharacter = "ऊ";
                flagFinal = true;
            }

            if (EngCharacter == "e")
            {
                HinCharacter = "ए";
                flagFinal = true;
            }

            if (EngCharacter == "ai")
            {
                HinCharacter = "ऐ";
                flagFinal = true;
            }

            if (EngCharacter == "o")
            {
                HinCharacter = "ओ";
                flagFinal = true;
            }

            if (EngCharacter == "au")
            {
                HinCharacter = "औ";
                flagFinal = true;
            }

            if (EngCharacter == "aM")
            {
                flagFinal = true;
                HinCharacter = "अं";
            }

            if (EngCharacter == "aH")
            {
                flagFinal = true;
                HinCharacter = "अः";
            }
            #endregion

            //Unicode Translations with Digits
            #region Digits
            if (EngCharacter == "0")
                HinCharacter = "०";

            if (EngCharacter == "1")
                HinCharacter = "१";

            if (EngCharacter == "2")
                HinCharacter = "२";

            if (EngCharacter == "3")
                HinCharacter = "३";

            if (EngCharacter == "4")
                HinCharacter = "४";

            if (EngCharacter == "5")
                HinCharacter = "५";

            if (EngCharacter == "6")
                HinCharacter = "६";

            if (EngCharacter == "7")
                HinCharacter = "७";

            if (EngCharacter == "8")
                HinCharacter = "८";

            if (EngCharacter == "9")
                HinCharacter = "९";

            #endregion

            //Special Accents
            #region Special Accents
            if (EngCharacter == "OM")
                HinCharacter = "ॐ";

            if (EngCharacter == "g.n")
                HinCharacter = "गं";

            if (EngCharacter == "D.N")
                HinCharacter = "डँ";
            #endregion

            return HinCharacter;
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());  
            if (e.KeyCode == Keys.ControlKey)
            {
                //breakWord = true;
                flagFinal = true;
                hindiCharacter = GetHindi(engAlphabets);
                if (hindiCharacter != string.Empty)
                {
                    if (flagFinal == true)
                    {
                        //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                        richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                        engAlphabets = string.Empty;
                        richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                        flagFinal = false;
                    }
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (upperSymbolCounter == 4)
                {
                    upperSymbolCounter = 0;
                    richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart - 1);
                }

                upperSymbolCounter += 1;
                if (upperSymbolCounter == 1)
                {
                    richTextBox1.Text = richTextBox1.Text + "ँ";
                    engAlphabets = string.Empty;
                    richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                }
                else if (upperSymbolCounter == 2)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart - 1);
                    richTextBox1.Text = richTextBox1.Text + "ः";
                    engAlphabets = string.Empty;
                    richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                }
                else if (upperSymbolCounter == 3)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart - 1);
                    richTextBox1.Text = richTextBox1.Text + "ं";
                    engAlphabets = string.Empty;
                    richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                }

                else if (upperSymbolCounter == 4)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart - 1);
                    richTextBox1.Text = richTextBox1.Text + "ृ";
                    engAlphabets = string.Empty;
                    richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                }
            }  
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            selectionStartValue = richTextBox1.SelectionStart;
            //button1.Text = selectionStartValue.ToString();

            lastCharacter = string.Empty;
            hindiCharacter = string.Empty;

            textLength = richTextBox1.Text.Length;

            if (richTextBox1.Text.Length > 0)
            {
                //lastCharacter = richTextBox1.Text.Substring(richTextBox1.Text.Length - 1, 1);
                if (openFlag == false && richTextBox1.SelectionStart > 0)  
                    lastCharacter = richTextBox1.Text.Substring(richTextBox1.SelectionStart - 1, 1);

                if (breakWord == true)
                {
                    flagFinal = true;
                    hindiCharacter = GetHindi(engAlphabets);
                    if (hindiCharacter != string.Empty)
                    {
                        if (flagFinal == true)
                        {
                            //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                            richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                            engAlphabets = string.Empty;
                            richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                            flagFinal = false;
                        }
                    }
                    breakWord = false;
                }

                if (engAlphabets == "a")
                {
                    if (lastCharacter != "a" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                engAlphabets = string.Empty;
                                richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                flagFinal = false;
                            }
                        }
                    }
                }

                if (engAlphabets == "ka" || engAlphabets == "ki" || engAlphabets == "ku" || engAlphabets == "k")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" && lastCharacter != "M" && lastCharacter != "h" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                ////richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "kha" || engAlphabets == "khi" || engAlphabets == "khu" || engAlphabets == "kh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ga" || engAlphabets == "gi" || engAlphabets == "gu" || engAlphabets == "g")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" && lastCharacter != "h" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "gha" || engAlphabets == "ghi" || engAlphabets == "ghu" || engAlphabets == "gh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "cha" || engAlphabets == "chi" || engAlphabets == "chu" || engAlphabets == "ch")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "chha" || engAlphabets == "chhi" || engAlphabets == "chhu" || engAlphabets == "chh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ja" || engAlphabets == "ji" || engAlphabets == "ju" || engAlphabets == "j")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "jha" || engAlphabets == "jhi" || engAlphabets == "jhu" || engAlphabets == "jh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "Ta" || engAlphabets == "Ti" || engAlphabets == "Tu" || engAlphabets == "T")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "Tha" || engAlphabets == "Thi" || engAlphabets == "Thu" || engAlphabets == "Th")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "Da" || engAlphabets == "Di" || engAlphabets == "Du" || engAlphabets == "D")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "Dha" || engAlphabets == "Dhi" || engAlphabets == "Dhu" || engAlphabets == "Dh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "Na" || engAlphabets == "Ni" || engAlphabets == "Nu" || engAlphabets == "N")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ta" || engAlphabets == "ti" || engAlphabets == "tu" || engAlphabets == "t")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "tha" || engAlphabets == "thi" || engAlphabets == "thu" || engAlphabets == "th")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "da" || engAlphabets == "di" || engAlphabets == "du" || engAlphabets == "d")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" && lastCharacter != "h" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "dha" || engAlphabets == "dhi" || engAlphabets == "dhu" || engAlphabets == "dh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "na" || engAlphabets == "ni" || engAlphabets == "nu" || engAlphabets == "n")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "pa" || engAlphabets == "pi" || engAlphabets == "pu" || engAlphabets == "p")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "pha" || engAlphabets == "phi" || engAlphabets == "phu" || engAlphabets == "ph" || engAlphabets == "fa" || engAlphabets == "fi" || engAlphabets == "fu" || engAlphabets == "f")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ba" || engAlphabets == "bi" || engAlphabets == "bu" || engAlphabets == "b")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" && lastCharacter != "h" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "bha" || engAlphabets == "bhi" || engAlphabets == "bhu" || engAlphabets == "bh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ma" || engAlphabets == "mi" || engAlphabets == "mu" || engAlphabets == "m")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ya" || engAlphabets == "yi" || engAlphabets == "yu" || engAlphabets == "y")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ra" || engAlphabets == "ri" || engAlphabets == "ru" || engAlphabets == "r")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "la" || engAlphabets == "li" || engAlphabets == "lu" || engAlphabets == "l")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "La" || engAlphabets == "Li" || engAlphabets == "Lu" || engAlphabets == "L")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "va" || engAlphabets == "vi" || engAlphabets == "vu" || engAlphabets == "v" || engAlphabets == "wa" || engAlphabets == "wi" || engAlphabets == "wu" || engAlphabets == "w")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "sha" || engAlphabets == "shi" || engAlphabets == "shu" || engAlphabets == "sh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "Sha" || engAlphabets == "Shi" || engAlphabets == "Shu" || engAlphabets == "Sh" || engAlphabets == "shha" || engAlphabets == "shhi" || engAlphabets == "shhu" || engAlphabets == "shh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "sa" || engAlphabets == "si" || engAlphabets == "su" || engAlphabets == "s")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" && lastCharacter != "h" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ha" || engAlphabets == "hi" || engAlphabets == "hu" || engAlphabets == "h")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (engAlphabets == "ksha" || engAlphabets == "kshi" || engAlphabets == "kshu" || engAlphabets == "ksh")
                {
                    if (lastCharacter != "a" && lastCharacter != "i" && lastCharacter != "u" && lastCharacter != "e" && lastCharacter != "o" || engAlphabets == " ")
                    {
                        flagFinal = true;
                        hindiCharacter = GetHindi(engAlphabets);
                        if (hindiCharacter != string.Empty)
                        {
                            if (flagFinal == true)
                            {
                                //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                                //richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
                                //engAlphabets = string.Empty;
                                //richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                                //flagFinal = false;
                                WriteHindi();
                            }
                        }
                    }
                }

                if (lastCharacter == " ")
                {
                    engAlphabets = string.Empty;
                }

                //transcomus.com

                if (alphabets.Contains(lastCharacter))
                {
                    engAlphabets = engAlphabets + lastCharacter;
                }
                //MessageBox.Show(engAlphabets.ToString());

                //selectionStartValue = selectionStartValue - (engAlphabets.Length - 1);
                hindiCharacter = GetHindi(engAlphabets);
                if (hindiCharacter != string.Empty)
                {
                    if (flagFinal == true)
                    {
                        string preContent = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart);
                        string postContent = richTextBox1.Text.Substring(richTextBox1.SelectionStart, richTextBox1.Text.Length - preContent.Length);
                        string content = preContent + hindiCharacter + postContent;

                        //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
                        richTextBox1.Text = content;
                        richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, "");
                        engAlphabets = string.Empty;
                        richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
                        flagFinal = false;
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("c:/rtfTest.rtf");  
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFlag = true ;
            richTextBox1.LoadFile("c:/rtfTest.rtf");
            openFlag = false;            
        }

        private void WriteHindi()
        {
            //richTextBox1.Text = richTextBox1.Text + hindiCharacter;
            richTextBox1.Text = richTextBox1.Text.Replace(engAlphabets, hindiCharacter);
            engAlphabets = string.Empty;
            richTextBox1.SelectionStart = Convert.ToInt32(selectionStartValue);
            flagFinal = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Outlook.Application objOutlook = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mic = (Microsoft.Office.Interop.Outlook.MailItem)(objOutlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem));

            mic.To = "kshitij.jhangra@silicus.com";
            //mic.CC = "cc";
            //mic.BCC = "bcc";

            mic.Subject = hindiTextBox1.Text  ;

            mic.SaveAs(@"C:\demo.msg", Microsoft.Office.Interop.Outlook.OlSaveAsType.olMSG);
            mic.Send();

            //webBrowser1.Navigate("mailto:Someone@someplace?Subject=" + @hindiTextBox1.Text );  
        }   
     

    }
}