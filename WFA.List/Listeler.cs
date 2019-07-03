using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.List
{
    class Listeler
    {
        #region Hayvanlar
        List<string> lhayvanlar = new List<string>();
        List<string> lkediler = new List<string>();
        #endregion


        List<string> lsavasci = new List<string>();
        List<string> lskills = new List<string>();

        public bool SavasciCikar(string savasci)
        {
            lsavasci.Remove(savasci);

            return true;
        }

        public bool SkillCikar(string savasci)
        {
            lskills.Remove(savasci);

            return true;
        }

        public bool SavasciEkle(string savasci)
        {
            lsavasci.Add(savasci);
            //lsavasci.Insert(1,savasci);
            return true;
        }

        public void SkillGoruntule()
        {
            /*foreach (string i in lskills)
                MessageBox.Show(i);*/
            string skillgoster = string.Join(",", lskills.ToArray());
            MessageBox.Show(skillgoster);

        }
        public void SavasciGoruntule()
        {
            //lsavasci.Reverse();
            foreach(string i in lsavasci)
            {
                MessageBox.Show(i);
            }

        }
        public bool SkilEkle(string skill)
        {
           // lskills.Reverse();
            lskills.Add(skill);
            return true;
        }

        public int BinarySearch(string a)
        {

            int index;
            index = lsavasci.BinarySearch(a);
            return index;

        }

        
        
      
        

        


    }

}
