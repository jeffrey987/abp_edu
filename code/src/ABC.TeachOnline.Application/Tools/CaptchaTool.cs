using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Caching.Memory;

namespace ABC.TeachOnline.Tools;

public class CaptchaTool
{
    //随机发生器 
    static Random r = new Random(Guid.NewGuid().GetHashCode());

//排除黑色、透明色颜色，因为底色黑色 
    //static PropertyInfo[] colors = (typeof(Brushes).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Static)).Where(p => p.Name != "Black" && p.Name != "Transparent").Select(p => p).ToArray(); 
    //Generate generates a random id, base64 image string or an error if any
    public Capthcha Generate()
    {
        IMemoryCache cache = new MemoryCache(new MemoryCacheOptions());
        var result = new Capthcha();
        result.Id = Guid.NewGuid().ToString();

        var answer = GenerateQuestionAnswer();
        cache.Set(result.Id, answer);
        result.Base64 = "data:image/jpeg;base64," + DrawCaptcha(answer);
        return result;
    }

    private string DrawCaptcha(string answer)
    {
        Bitmap bmp = new Bitmap(100, 40);
        Graphics g = Graphics.FromImage(bmp);
        g.Clear(Color.FromArgb(255, 20, 110, 250));
        Pen pen = new Pen(Color.LightGray);
        int linenum = r.Next(10, 21);
        //GraphicsPath path=new GraphicsPath();
        // path.AddEllipse();
        // g.FillPath(new HatchBrush(HatchStyle.BackwardDiagonal,Color.LightGray),path);
        for (int i = 1; i <= linenum; i++)
        {
            double PERNUMBERWIDTH = 40f;
            double reqNum = 4f;
            double PERNUMBERHEIGHT = 50f;
            g.DrawLine(pen,
                new PointF((float) (r.NextDouble() * PERNUMBERWIDTH * reqNum),
                    (float) (r.NextDouble() * PERNUMBERHEIGHT)),
                new PointF((float) (r.NextDouble() * PERNUMBERWIDTH * reqNum),
                    (float) (r.NextDouble() * PERNUMBERHEIGHT)));
        }

        // g.FillRectangle(new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(255,0,0,0),Color.Transparent), g.ClipBounds );
        // g.FillRectangle(new HatchBrush(HatchStyle.ForwardDiagonal, Color.FromArgb(255, 0, 0, 0), Color.Transparent), g.ClipBounds);
        g.DrawString(answer, new Font("Courier", 16),
            new SolidBrush(Color.WhiteSmoke), 2, 6);
        using (MemoryStream ms = new MemoryStream())
        {
            // Convert Image to byte[]
            bmp.Save(ms, ImageFormat.Jpeg);
            bmp.Save(answer + ".jpeg");
            byte[] imageBytes = ms.ToArray();
            // Convert byte[] to base 64 string
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }
    }

    private string GenerateQuestionAnswer()
    {
        StringBuilder result = new StringBuilder();
        Random random = new Random();
        for (int i = 0; i < 4; i++)
        {
            var val = random.Next(0, ConstTool.idChars.Length);
            result.Append(ConstTool.idChars[val]);
        }

        return result.ToString();
    }
}

public class Capthcha
{
    public string Id { get; set; }

    public string Answer { get; set; }

    public string Base64 { get; set; }
}