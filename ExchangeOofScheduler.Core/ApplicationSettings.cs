using Ninject;
using System.Collections.Specialized;
using System.Configuration;

namespace ExchangeOofScheduler.Core
{
  public class ApplicationSettings : IApplicationSettings
  {
    private readonly NameValueCollection applicationSettings;

    [Inject]
    public ApplicationSettings()
      : this(ConfigurationManager.AppSettings)
    {
    }

    // Used for testing
    public ApplicationSettings(NameValueCollection applicationSettings)
    {
      this.applicationSettings = applicationSettings;
    }

    public string UserEmail
    {
      get
      {
        return applicationSettings["UserEmail"];
      }
    }

    public bool DebugModeEnabled
    {
      get { return bool.Parse(applicationSettings["DebugModeEnabled"]); }
    }

    public string StartDay
    {
      get { return applicationSettings["StartDay"]; }
    }

    public string BoundaryTime
    {
      get { return applicationSettings["BoundaryTime"]; }
    }

    public string EndDay
    {
      get { return applicationSettings["EndDay"]; }
    }

    public string InternalReply
    {
      get { return applicationSettings["InternalReply"]; }
    }

    public string SendToExternalRecipients
    {
      get
      {
        return applicationSettings["SendToExternalRecipients"];
      }
    }

    public string ExternalReply
    {
      get { return applicationSettings["ExternalReply"]; }
    }
  }
}