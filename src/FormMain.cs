using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
#pragma warning disable CA1416

namespace UsingDotNET.SetProxy;

public partial class FormMain : Form
{
    [DllImport("wininet.dll")]
    public static extern bool InternetSetOption(nint hInternet, int dwOption, nint lpBuffer, int dwBufferLength);

    public const int InternetOptionSettingsChanged = 39;
    public const int InternetOptionRefresh = 37;
    private const string UserRoot = "HKEY_CURRENT_USER";
    private const string Subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
    private static string _keyName = "";
    private const string ProxyEnable = "ProxyEnable";
    private const string ProxyServer = "ProxyServer";
    private const string ProxyOverride = "ProxyOverride";
    private string _proxy = "";
    //private string bypass = "";
    private const string ByPassFile = "proxyByPass.ini";

    public FormMain()
    {
        InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        _keyName = UserRoot + "\\" + Subkey;
        var enbled = Registry.GetValue(_keyName, ProxyEnable, 0);
        if (enbled is int en)
        {
            chkEnabled.Checked = en == 1;
        }

        var ps = Registry.GetValue(_keyName, ProxyServer, "");
        if (ps is string p)
        {
            txtProxyServer.Text = p;
            _proxy = p;
        }

        if (File.Exists(ByPassFile))
        {
            txtProxyByPass.Text = File.ReadAllText(ByPassFile, Encoding.UTF8);
        }
        else
        {
            var bs = Registry.GetValue(_keyName, ProxyOverride, "");
            if (bs is string b1)
            {
                var ax = b1.Replace(";", Environment.NewLine);
                txtProxyByPass.Text = ax;
            }
        }
    }


    private void SetProxy()
    {
        if (string.IsNullOrEmpty(txtProxyServer.Text))
        {
            return;
        }

        _proxy = txtProxyServer.Text;
        if (_proxy.Length != 0)
            Registry.SetValue(_keyName, ProxyServer, _proxy);

        ToggleProxy();
        File.WriteAllText(ByPassFile, txtProxyByPass.Text);
        var list = new List<string>(Regex.Split(txtProxyByPass.Text, Environment.NewLine));

        var real = new List<string>();
        foreach (string s in list)
        {
            if (!string.IsNullOrEmpty(s) && !s.StartsWith("--") && !s.StartsWith(";"))
            {
                real.Add(s);
            }
        }

        string bypass = string.Join(";", real.ToArray());

        if (bypass.Length != 0)
            Registry.SetValue(_keyName, ProxyOverride, bypass);

        // These lines implement the Interface in the beginning of program 
        // They cause the OS to refresh the settings, causing IP to realy update
        InternetSetOption(nint.Zero, InternetOptionSettingsChanged, nint.Zero, 0);
        InternetSetOption(nint.Zero, InternetOptionRefresh, nint.Zero, 0);
    }

    private void ToggleProxy()
    {
        Registry.SetValue(_keyName, ProxyEnable, chkEnabled.Checked ? 1 : 0, RegistryValueKind.DWord);
    }

    private void btnSetProxy_Click(object sender, EventArgs e)
    {
        SetProxy();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ProcessStartInfo psi = new()
        {
            UseShellExecute = true,
            FileName = "ms-settings:network-proxy"
        };

        Process.Start(psi);
    }

    private void chkEnabled_CheckedChanged(object sender, EventArgs e)
    {
        ToggleProxy();
    }
}