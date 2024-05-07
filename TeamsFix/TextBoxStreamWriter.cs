using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TeamsFix
{
    public class TextBoxStreamWriter : TextWriter
    {
        RichTextBox _output = null;

        public TextBoxStreamWriter(RichTextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.Invoke(new Action(() => { _output.AppendText(value.ToString()); }));
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}