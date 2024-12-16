using System;
using System.Drawing.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project.V8;

[Serializable]
public class CellStyleSettings
{
    private string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\Settings.bin";

    public Font Font { get; set; }
    public Color SelectionForeColor {  get; set; }
    public Color SelectionBackColor { get; set; }

    public CellStyleSettings(Font font, Color selectionForeColor, Color selectionBackColor)
    {
        Font = font;
        SelectionForeColor = selectionForeColor;
        SelectionBackColor = selectionBackColor;
    }

    public CellStyleSettings()
    {
        Font = new Font("Segoe UI", 9);
        SelectionForeColor = SystemColors.HighlightText;
        SelectionBackColor = SystemColors.Highlight;
    }

    public void Read()
    {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
        BinaryFormatter formatter = new();
#pragma warning restore SYSLIB0011 // Type or member is obsolete

        if (!File.Exists(filePath))
        {
            Font = new Font("Segoe UI", 9);
            SelectionForeColor = SystemColors.HighlightText;
            SelectionBackColor = SystemColors.Highlight;
            return;
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            var s = (CellStyleSettings)formatter.Deserialize(fs);
            Font = s.Font;
            SelectionBackColor = s.SelectionBackColor;
            SelectionForeColor = s.SelectionForeColor;
        }
    }

    public void Write()
    {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
        BinaryFormatter formatter = new();
#pragma warning restore SYSLIB0011 // Type or member is obsolete

        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, this);
        }
    }
}
