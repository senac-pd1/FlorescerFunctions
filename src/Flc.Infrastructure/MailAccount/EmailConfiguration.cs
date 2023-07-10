using System;
using System.ComponentModel.DataAnnotations;

namespace Flc.Infrastructure.MailAccount;

public class EmailConfiguration
{
    [Required]
    public string From { get; set; } = default!;
    public string FromName { get; set; } = default!;
    public string HostAddress { get; set; } = default!;
    public string AccountSender { get; set; } = default!;
    public string Password { get; set; } = default!;
    public bool EnabledSendMails { get; set; }

    /// <summary>
    /// Additional emails used for following all e-mails without impact the original e-mail destination
    /// </summary>
    public string[] CCFollowers { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Additional subject used to add more details for better visualization
    /// </summary>
    public string SubjectComplement { get; set; } = default!;

    public bool IsEmailBodyHtml { get; set; } = true;

    public OverwriteEmailConfiguration Overwrite { get; set; } = new OverwriteEmailConfiguration();
}

public class OverwriteEmailConfiguration
{
    /// <summary>
    /// Enabled or disabled redirect mails feature
    /// </summary>
    [Required]
    public bool Enabled { get; set; } = false;

    /// <summary>
    /// ToMails used for redirect all e-mails for this list of mails,
    /// without sending mails to the original e-mail destination 
    /// </summary>
    public string[] To { get; set; } = Array.Empty<string>();

    /// <summary>
    /// CCMails used for redirect all e-mails as a copy for this list of mails,
    /// without sendings mails as a copy to the original e-mail destination
    /// </summary>
    public string[] CC { get; set; } = Array.Empty<string>();
}

