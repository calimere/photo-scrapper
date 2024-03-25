using System.IO;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;


var sr = new StreamReader(@"C:\\temp\\files.csv");
var line = sr.ReadLine();
var iterator = 0;

while (line != null)
{
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{line}");
    request.Method = "GET";
    request.Headers.Add("Accept", "application/json");
    request.Headers.Add("Cookie", "cookietest=eyJpdiI6IkU0UG43Z2hzbFRJRnM4Um51QzBrVmc9PSIsInZhbHVlIjoiZWw3a1FEamZnZGhCMWhXY2lJZFoyTzFMWm56Rmh6dGV0bmNwUDhrdHhlaHdQT3I4Qm9HSnRVVUtJY1hUdlp5ZyIsIm1hYyI6ImIxNzk3MDQxMTdhM2RjM2ExMTFjNjQ4MjQ5ZjdjOTA4NzZiY2E2NzNkMzE3ZWQ4YjcyMGIwNzU3ZDlmNGE4MWMiLCJ0YWciOiIifQ%3D%3D; noShowAlbumPopupAnymore_1b47ce51-e934-429c-acdd-1174e4e9934a=1; remember_web_59ba36addc2b2f9401580f014c7f58ea4e30989d=eyJpdiI6Imh6RGhXTjVYVEE1aEtjanUrZlpaVEE9PSIsInZhbHVlIjoiU2JlSkVrRTZydzJtMER2a0g1N1ltbHlPaFVnUG5VbVJsK0tyek9RRHdNTDJVbWJrZUZFdXp5a0RJV0NkaDF0VUxTd05GZ2pKRnp0aEZMeTZBeFA1N0JPZGJZaFFsYWxHa3RZVEluR0tWL015eVBZWDhXdmswYkhwNllWNE9vMTVWWVNRa282ZGpEZ0FibUQ2b2JZd3N3PT0iLCJtYWMiOiIxNjI4MTEzNzMyOTRkYWNhZTVkNzMzMWEzNjI5ZmVkYzU0MDllMjk4YzY4YjhiYzYwNzA1ZTI4ZjMzM2ExMTgyIiwidGFnIjoiIn0%3D; last_seen_68237=eyJpdiI6IlRpMmFYWWlZRmo3cnlhUkdJRC9sbkE9PSIsInZhbHVlIjoiSnRFdklDS01GazdwRmQyMldLL1BYTmJDR0RoNEV4SFI1L1lCaFVQS3l4RjRhS2RWTjZPblJYT01kVFRJSkN5dlh2ZU03UDlvb0tKNW15WHhUZEdoL0E9PSIsIm1hYyI6IjY2N2Q5NTFkZGNmZDBhNDhjZTYzYzVmMTM4NGM0NTgxYmVlZmVkY2M5MzQ2MjYyODlmNWY3MjUyNjk2ZWY1YWEiLCJ0YWciOiIifQ%3D%3D; XSRF-TOKEN=eyJpdiI6ImdiUzBuZElnM3VZWGRORVQ5bFM2M2c9PSIsInZhbHVlIjoiOVdHL2g1SEFJeDlpR3Z3SG1iOHpHRXdoQitVcWppbFZhalJHVVkyc3B3bW14ZGVFMnUzdTkyTmZndEZ6RFNialNUc3JGMnZDYVFJVi9PNDVWbkErSmNsb3Z2eWE0UEl2Y1hGRUd3dWJXSE9sM2tOUTA4VERPSXN1Y09CaUMrbTciLCJtYWMiOiJhNTViYzQyNjQxYTYzNWU1NGE0ZmVmNmVkNTZiOTg5YWM1ZGQ5Njk2OWFhMjA4ZjZlYTc1MmZiNjRmYmRkZWZmIiwidGFnIjoiIn0%3D; diedm_session=eyJpdiI6InpQeTF3aG05aHB0Vit2NmpJVVVGUkE9PSIsInZhbHVlIjoiNDZzd0FINENFNHFBRmplRWZKU1JaYi9WSTEzYURhYjFUVjVHRitWdWJqbURaZDdGdnk0ZmhaTGs3WUxKbGpVa09sSUhLdlJpcmoxa1N6eDhZVHVORXBXemQwUGNQa2paWG9SYmY0NlB5eFBFL2dLRTdpOGZJMWFOVW1rYmZmR3EiLCJtYWMiOiI5NDhiYWE5NGU3MGQ1OGFkODVjOGRhZWNkZDg5ZTQ5ZWYxZTI5NjFkN2VhNTdlOTBlOTRlZTM5OTYxYTVkNTE3IiwidGFnIjoiIn0%3D");

    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
    {
        using (Stream stream = response.GetResponseStream())
        {
            Bitmap image = new Bitmap(stream);
            image.Save($"C:\\temp\\{iterator.ToString("D3")}.jpg", ImageFormat.Jpeg);
        }
    }

    line = sr.ReadLine();
    iterator++;
}


