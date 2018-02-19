using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultipleUpload
{
    public partial class UploadMultipleFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            form1.Enctype = "multipart/form-data";
            if (!IsPostBack)
            {
                fillgrid();
            }
        }

        public void fillgrid()
        {
            using (UploadDBEntities udbe = new UploadDBEntities())
            {

                GridView1.DataSource = udbe.tbl_image.ToList();
                GridView1.DataBind();
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            HttpFileCollection flCollection = Request.Files;
            using (UploadDBEntities udbe = new UploadDBEntities())
            {
                foreach (string upldr in flCollection)
                {
                    HttpPostedFile fl = flCollection[upldr];

                    if (fl.ContentLength > 0)
                    {
                        BinaryReader br = new BinaryReader(fl.InputStream);
                        byte[] bffr = br.ReadBytes(fl.ContentLength);

                        tbl_image timg = new tbl_image();
                        timg.ImageName = fl.FileName;
                        timg.FileSize = fl.ContentLength;
                        timg.FileExtension = Path.GetExtension(fl.FileName);
                        timg.FileContent = fl.ContentType;

                        udbe.tbl_image.Add(timg);
                        udbe.SaveChanges();
                    }
                }
            }

            fillgrid();
        }
    }
}