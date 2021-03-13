using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;
using System.Text;
using XrmToolBox.Extensibility;

namespace PowerDataOps.Xtb.Plugin
{
    public partial class PowerDataOpsPluginControl : PluginControlBase
    {
        public PowerDataOpsPluginControl()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ShowInfoNotification("PowerDataOps module requires PowerShell 5.1 with PowershellGet.", new Uri("https://docs.microsoft.com/en-us/powershell/scripting/gallery/installing-psget?view=powershell-7.1"), 32);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            var commandBuilder = new StringBuilder();
            commandBuilder.AppendLine("if (-not(Get-Module -ListAvailable -Name PowerDataOps)) {");
            commandBuilder.AppendLine("  Install-Module -Name PowerDataOps -Scope CurrentUser -SkipPublisherCheck -Force -Confirm:$false -Verbose;");
            commandBuilder.AppendLine("}");
            commandBuilder.AppendLine("else {");
            commandBuilder.AppendLine("   Update-Module -Name PowerDataOps -Confirm:$false -Verbose;");
            commandBuilder.AppendLine("}");

            txtScripting.Text = commandBuilder.ToString();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            var commandBuilder = new StringBuilder();
            commandBuilder.AppendLine("start 'https://github.com/AymericM78/PowerDataOps'");

            txtScripting.Text = commandBuilder.ToString();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(this.ConnectionDetail == null)
            {
                ShowErrorNotification("You must be connected to an instance first.", null, 32);
                return;
            }

            var cs = this.ConnectionDetail.ConnectionString;
            if(string.IsNullOrWhiteSpace(cs))
            {
                cs = this.ConnectionDetail.GetConnectionString();
                cs = cs.Replace("********", this.ConnectionDetail.UserPasswordEncrypted);
            }

            var commandBuilder = new StringBuilder();
            commandBuilder.AppendLine($"Import-Module PowerDataOps -DisableNameChecking; ");
            commandBuilder.AppendLine($"$client = New-XrmClient -ConnectionString '{cs}' -IsEncrypted $true; ");

            txtScripting.Text = commandBuilder.ToString();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var commands = txtScripting.Text;
            RunPshell(commands);
        }

        private void RunPshell(string commands)
        {
            Process cmd = new Process();
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.FileName = "powershell.exe";
            cmd.StartInfo.Arguments = $"-ExecutionPolicy Unrestricted -NoExit -Command \"{commands}\"";
            cmd.StartInfo.CreateNoWindow = false;
            cmd.Start();
        }
    }
}