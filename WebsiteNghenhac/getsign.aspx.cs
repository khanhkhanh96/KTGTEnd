using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SteganoWave;
using System.Text;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Download;
using Google.Apis.Util.Store;
using GoogleDriveRestAPI_v3.Models;

public partial class getsign : System.Web.UI.Page
{
    string fullSavePath = HttpContext.Current.Server.MapPath(string.Format("~/App_Data/"));
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Stream sourceStream = null;
        WaveStream audioStream = null;
        //create an empty stream to receive the extracted message
        MemoryStream messageStream = new MemoryStream();
        //open the key file
        Stream keyStream = new FileStream(fullSavePath + "key.txt", FileMode.Open);

        try
        {
            //open the carrier file
            sourceStream = FileUpload1.PostedFile.InputStream;
            audioStream = new WaveStream(sourceStream);
            WaveUtility utility = new WaveUtility(audioStream);

            //exctract the message from the carrier wave
            utility.Extract(messageStream, keyStream);

            messageStream.Seek(0, SeekOrigin.Begin);

            { //display result
                Label1.Text = new StreamReader(messageStream).ReadToEnd();
            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            if (keyStream != null) { keyStream.Close(); }
            if (messageStream != null) { messageStream.Close(); }
            if (audioStream != null) { audioStream.Close(); }
            if (sourceStream != null) { sourceStream.Close(); }
        }
    }
}
