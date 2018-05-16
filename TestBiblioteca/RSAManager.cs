using Jose;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TestBiblioteca
{
  public partial class RSAManager : Form
  {
    public RSAManager()
    {
      InitializeComponent();
    }

    private void btnGenerateToken_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtPayLoad.Text))
      {
        //Generate Token      
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        rsa.FromXmlString(RsaKeyConverter.Converter.RsaKeyConverter.PemToXml(txtPrivateKey.Text));

        string token = Jose.JWT.Encode(txtPayLoad.Text, rsa, JwsAlgorithm.RS256);
        txtToken.Text = token;
      }
    }

    private void btnDecodeToken_Click(object sender, EventArgs e)
    {
      //Decode token
      if (!string.IsNullOrEmpty(txtToken.Text))
      {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        rsa.FromXmlString(RsaKeyConverter.Converter.RsaKeyConverter.PemToXml(txtPublicKey.Text));

        string decoded_token = Jose.JWT.Decode(txtToken.Text, rsa, JwsAlgorithm.RS256);
        txtDecodeToken.Text = decoded_token;
      }
    }

    private void btnRSAPublicGen_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtPublicKey.Text))
      {
        string xml = RsaKeyConverter.Converter.RsaKeyConverter.PemToXml(txtPublicKey.Text);
        txtXMLRsaPublic.Text = xml;
      }
    }

    private void btnRSAPrivateGen_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtPrivateKey.Text))
      {
        string xml = RsaKeyConverter.Converter.RsaKeyConverter.PemToXml(txtPrivateKey.Text);
        txtXMLRSAPrivate.Text = xml;
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtToken.Text = txtDecodeToken.Text = txtXMLRsaPublic.Text = txtXMLRSAPrivate.Text = string.Empty;
    }

    private void btnGenerateKeyPair_Click(object sender, EventArgs e)
    {      
      RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
      txtPrivateKey.Text = RsaKeyConverter.Converter.RsaKeyConverter.XmlToPem(rsa.ToXmlString(true));
      txtPublicKey.Text = RsaKeyConverter.Converter.RsaKeyConverter.XmlToPem(rsa.ToXmlString(false));

    }
  }
}
