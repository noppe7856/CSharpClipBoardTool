using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipToolTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();
            // ClipBoardからstring配列形式で取得する
            string[] input = Clipboard.GetText(TextDataFormat.UnicodeText).Replace(Environment.NewLine, "\n").Split('\n');


            // TODO
            string[] edit = input.Select(n => n + " a").ToArray();

            // データをClibboardに設定する。
            string output = string.Join(Environment.NewLine, edit);
            Clipboard.SetText(output, TextDataFormat.UnicodeText);
        }
    }
}
